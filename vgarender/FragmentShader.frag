#version 130

// shader assumes that sprite is stretched to full window

// https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/gl_FragCoord.xhtml
// gl_FragCoord // x 0-800, y 600-0 (Y inverted by default)
// gl_TexCoord[0].xy // x 0-1, y 0-1

uniform sampler2D texture;
uniform vec2 windowSize; // 800, 600

vec2 pixelSize = 1.0 / windowSize;

// CHANNEL_SOURCE
uniform ivec3 channelSource;

uniform int   colorInvert;
uniform vec3  grayColorRatio;
uniform float contrast;
uniform float brightness;
uniform float gamma;
uniform float grayThreshBlack;
uniform float grayThreshWhite;

uniform ivec3 oneBitEnabled;
uniform int   oneBitEncodingMode;

uniform float oneBitTop;
uniform float oneBitBottom;

// ONEBIT_VALUES
uniform int oneBitValues;
// index = ONEBIT_NEAREST_DIR
uniform float[2] oneBitNearestDirection;
uniform float    oneBitNearestMaxDistance;

uniform int   oneBitSwapMode;
uniform vec2  oneBitSwapAfter;
uniform vec2  oneBitSwapCheckered;

// accept matrix from external code
// size of (orderedMatrixFlat) should be (orderedMatrixFlatSize ^ 2)
uniform float[256] orderedMatrixFlat;
uniform int        orderedMatrixFlatSize;

// or define custom
// const int orderedMatrixFlatSize = 8;
// const int orderedMatrixFlat[64] = int[]( // 64 == orderedMatrixFlatSize ^ 2
//    0,  32, 8,  40, 2,  34, 10, 42,
//    48, 16, 56, 24, 50, 18, 58, 26,
//    12, 44, 4,  36, 14, 46, 6,  38,
//    60, 28, 52, 20, 62, 30, 54, 22,
//    3,  35, 11, 43, 1,  33, 9,  41,
//    51, 19, 59, 27, 49, 17, 57, 25,
//    15, 47, 7,  39, 13, 45, 5,  37,
//    63, 31, 55, 23, 61, 29, 53, 21);

uniform vec2 orderedShift;


// index = COLOR_CHANNEL
// vec3(startValue, endValue, GRADIENT_DITHER)
uniform vec3[3] gradientParams;


const int gradientOrderedMatrixFlatSize = 16*16;
uniform float[gradientOrderedMatrixFlatSize] gradientOrderedMatrixFlat;


uniform float pwmColor;

uniform float randomSeed;



const int ONEBIT_NONE    = 0;
const int ONEBIT_RANDOM  = 1;
const int ONEBIT_ORDERED = 2;
const int ONEBIT_PWM     = 3;

const int ONEBIT_SWAP_NONE      = 0;
const int ONEBIT_SWAP_AFTER     = 1;
const int ONEBIT_SWAP_CHECKERED = 2;
const int ONEBIT_SWAP_RANDOM    = 3;

const int ONEBIT_VALUES_CONST = 0;
const int ONEBIT_VALUES_NEAREST_ACTIVE = 1;

const int ONEBIT_NEAREST_DIR_PREV = 0;
const int ONEBIT_NEAREST_DIR_NEXT = 1;


const int COLOR_CHANNEL_RED   = 0;
const int COLOR_CHANNEL_GREEN = 1;
const int COLOR_CHANNEL_BLUE  = 2;

const int GRADIENT_DITHER_NONE    = 0;
const int GRADIENT_DITHER_RANDOM  = 1;
const int GRADIENT_DITHER_ORDERED = 2;


const int CHANNEL_SOURCE_X    = 0; // gradient horizontal
const int CHANNEL_SOURCE_Y    = 1; // gradient vectical
const int CHANNEL_SOURCE_GRAY = 2; // grayscaled image
const int CHANNEL_SOURCE_MIN  = 3; // gradient start value
const int CHANNEL_SOURCE_MAX  = 4; // gradient end value







float gammaCorrect(float gray, float gamma)
{
    return pow(gray, 1.0f / gamma);
    // for 0-255: 255 * pow(c / 255, 1 / gamma);
}


float rand(vec2 fragPixelPos, float seed) 
{
    return fract(sin(dot(fragPixelPos.xy, vec2(12.9898, 4.1414))) * seed);
}

vec4 getTexPixelColor(vec2 fragPixelPos)
{
    vec2 texCoord = fragPixelPos * pixelSize;
    texCoord = vec2(texCoord.x, 1.0 - texCoord.y);

    // vec2 texCoord = gl_TexCoord[0].xy;

    return texture2D(texture, texCoord);
}

float processColor(vec4 color)
{    
    float gray = 
        color.r * grayColorRatio.r + 
        color.g * grayColorRatio.g + 
        color.b * grayColorRatio.b;

    if (colorInvert == 1)
        gray = 1.0 - gray;

    gray = gray * contrast;
    if (gray > 1) gray = 1;

    gray = gray + brightness;
    if (gray > 1) gray = 1;
    else if (gray < 0) gray = 0;

    gray = gammaCorrect(gray, gamma);

    return gray;
}



float orderedDither(vec2 fragPixelPos, float[256] matrixFlat, int matrixSize, float color, bool binary) ;



bool isPixelBlanked(vec2 fragPixelPos, float gray)
{
    bool blankedPixel = false;
    
    if (gray > grayThreshWhite) 
    {
        blankedPixel = false;
    }
    else if (gray < grayThreshBlack) 
    {
        blankedPixel = true;
    }
    else if (oneBitEncodingMode == ONEBIT_RANDOM)
    {
        blankedPixel = gray < rand(fragPixelPos, randomSeed);
    }
    else if (oneBitEncodingMode == ONEBIT_ORDERED)
    {
        blankedPixel = orderedDither(fragPixelPos, orderedMatrixFlat, orderedMatrixFlatSize, gray, true) == 0.0;
    }
    else if (oneBitEncodingMode == ONEBIT_PWM)
    {
        blankedPixel = gray < pwmColor;
    }

    return blankedPixel;
}





float getOneBitLevel(vec2 fragPixelPos, bool state, vec2 pixelSize)
{
        
    if (oneBitValues == ONEBIT_VALUES_CONST)
    {
        return state ? oneBitTop : oneBitBottom;
    }
    else if (oneBitValues == ONEBIT_VALUES_NEAREST_ACTIVE)
    {
        float valuePrev = oneBitTop;
        float valuePrevDist = 1;
        float valueNext = oneBitBottom;
        float valueNextDist = 1;

        // if (oneBitNearestDirection[ONEBIT_NEAREST_DIR_PREV] != 0)
        // {
        //     int i = 1;
        //     while (true)
        //     {
        //         vec2 newPos = vec2(fragPixelPos.x - i, fragPixelPos.y);
        //         
        //         valuePrevDist = float(i) * pixelSize.x;
        // 
        //         if ((newPos.x < 0) || (valuePrevDist > oneBitNearestMaxDistance))
        //         {
        //             valuePrev = oneBitTop;
        //             break;
        //         }
        // 
        //         vec4 texPixelColor = getTexPixelColor(newPos);
        // 
        //         float gray = processColor(texPixelColor);
        // 
        //         bool blankedPixel = isPixelBlanked(newPos, gray);
        // 
        //         if (!blankedPixel)
        //         {
        //             valuePrev = newPos.x * pixelSize.x;
        //             break;
        //         }
        // 
        //         i++;
        //     }
        // }
        // 
        // if (oneBitNearestDirection[ONEBIT_NEAREST_DIR_NEXT] != 0)
        // {
        //     int i = 1;
        //     while (true)
        //     {
        //         vec2 newPos = vec2(fragPixelPos.x + i, fragPixelPos.y);
        // 
        //         valueNextDist = float(i) * pixelSize.x;
        // 
        //         if ((newPos.x > windowSize.x) || (valueNextDist > oneBitNearestMaxDistance))
        //         {
        //             valueNext = oneBitBottom;
        //             break;
        //         }
        // 
        //         vec4 texPixelColor = getTexPixelColor(newPos);
        // 
        //         float gray = processColor(texPixelColor);
        // 
        //         bool blankedPixel = isPixelBlanked(newPos, gray);
        // 
        //         if (!blankedPixel)
        //         {
        //             valueNext = newPos.x * pixelSize.x;
        //             break;
        //         }
        // 
        //         i++;
        //     }
        // }

        
        if (oneBitNearestDirection[ONEBIT_NEAREST_DIR_PREV] != 0)
        {
            int i = 1;
            while (true)
            {
                vec2 newPos = vec2(fragPixelPos.x, fragPixelPos.y - i);
                
                valuePrevDist = float(i) * pixelSize.y;
        
                if ((newPos.y < 0) || (valuePrevDist > oneBitNearestMaxDistance))
                {
                    valuePrev = oneBitTop;
                    break;
                }
        
                vec4 texPixelColor = getTexPixelColor(newPos);
        
                float gray = processColor(texPixelColor);
        
                bool blankedPixel = isPixelBlanked(newPos, gray);
        
                if (!blankedPixel)
                {
                    valuePrev = newPos.y * pixelSize.y;
                    break;
                }
        
                i++;
            }
        }
        
        if (oneBitNearestDirection[ONEBIT_NEAREST_DIR_NEXT] != 0)
        {
            int i = 1;
            while (true)
            {
                vec2 newPos = vec2(fragPixelPos.x, fragPixelPos.y + i);
        
                valueNextDist = float(i) * pixelSize.y;
        
                if ((newPos.y > windowSize.y) || (valueNextDist > oneBitNearestMaxDistance))
                {
                    valueNext = oneBitBottom;
                    break;
                }
        
                vec4 texPixelColor = getTexPixelColor(newPos);
        
                float gray = processColor(texPixelColor);
        
                bool blankedPixel = isPixelBlanked(newPos, gray);
        
                if (!blankedPixel)
                {
                    valueNext = newPos.y * pixelSize.y;
                    break;
                }
        
                i++;
            }
        }

        if (valuePrevDist > valueNextDist)
            return valueNext;

        if (valuePrevDist < valueNextDist)
            return valuePrev;

        return rand(fragPixelPos, randomSeed) > 0.5 ? valueNext : valuePrev;
    }
    else
    {
        return 0;
    }

}


bool getOneBitSwappedDirection(vec2 fragPixelPos)
{
    if (oneBitSwapMode == ONEBIT_SWAP_NONE)
    {
        return true;
    }
    else if (oneBitSwapMode == ONEBIT_SWAP_AFTER)
    {
        return (float(fragPixelPos.x) / oneBitSwapAfter.x < windowSize.x) || (float(fragPixelPos.y) / oneBitSwapAfter.y < windowSize.y);
    }
    else if (oneBitSwapMode == ONEBIT_SWAP_CHECKERED)
    {
        float checkW = windowSize.x * oneBitSwapCheckered.x;
        float checkH = windowSize.y * oneBitSwapCheckered.y;

        int fx = int(float(fragPixelPos.x) / checkW);
        int fy = int(float(fragPixelPos.y) / checkH);

        if (mod(fx, 2) == 1)
            return mod(fy, 2) == 1;
        else
            return mod(fy, 2) != 1;
    }
    else if (oneBitSwapMode == ONEBIT_SWAP_RANDOM)
    {
        return rand(fragPixelPos, randomSeed * 2) > 0.5;
    }

    return false;
}




//float getOneBitValue(vec2 fragPixelPos)
//{
//    if (oneBitSwapMode == ONEBIT_SWAP_NONE)
//    {
//        return oneBitTop;
//    }
//    else if (oneBitSwapMode == ONEBIT_SWAP_AFTER)
//    {
//        return (float(fragPixelPos.x) / oneBitSwapAfter.x < windowSize.x) || (float(fragPixelPos.y) / oneBitSwapAfter.y < windowSize.y)
//            ? oneBitBottom
//            : oneBitTop;
//    }
//    else if (oneBitSwapMode == ONEBIT_SWAP_CHECKERED)
//    {
//        float checkW = windowSize.x * oneBitSwapCheckered.x;
//        float checkH = windowSize.y * oneBitSwapCheckered.y;
//
//        int fx = int(float(fragPixelPos.x) / checkW);
//        int fy = int(float(fragPixelPos.y) / checkH);
//
//        if (mod(fx, 2) == 1)
//            return mod(fy, 2) == 1 ? oneBitTop : oneBitBottom;
//        else
//            return mod(fy, 2) == 1 ? oneBitBottom : oneBitTop;
//    }
//    else if (oneBitSwapMode == ONEBIT_SWAP_RANDOM)
//    {
//        return rand(fragPixelPos, randomSeed * 2) > 0.5
//            ? oneBitTop
//            : oneBitBottom;
//    }
//
//    return -1;
//}



float orderedIndexValue(vec2 fragPixelPos, float[256] matrixFlat, int matrixSize) 
{
    int x = int(mod(fragPixelPos.x + orderedShift.x, matrixSize));
    int y = int(mod(fragPixelPos.y + orderedShift.y, matrixSize));
    return matrixFlat[(x + y * matrixSize)] / float(matrixSize * matrixSize);
}

float orderedDither(vec2 fragPixelPos, float[256] matrixFlat, int matrixSize, float color, bool binary) 
{
    float closestColor;
    float secondClosestColor;

    if (binary)
    {
        closestColor = (color < 0.5) ? 0 : 1;
        secondClosestColor = 1 - closestColor;
    }
    else
    {
        float quad = matrixSize*matrixSize;
        closestColor = trunc(color * quad) / quad;
        secondClosestColor = ceil(color * quad) / quad;
    }

    float d = orderedIndexValue(fragPixelPos, matrixFlat, matrixSize);
    float distance = abs(closestColor - color);
    return (distance < d) ? closestColor : secondClosestColor;
}



float getGradient(vec2 fragPixelPos, int channelId, bool horizontal)
{
    // vec3(startValue, endValue, GRADIENT_DITHER)
    vec3 g = gradientParams[channelId];

    float diff = g.y - g.x;
    float value = 0;

    if (horizontal)
    {
        value = g.x + diff * fragPixelPos.x / windowSize.x;
    }
    else
    {
        value = g.x + diff * fragPixelPos.y / windowSize.y;
    }

    if (g.z == GRADIENT_DITHER_NONE)
    {
        // nothing
    }
    else if (g.z == GRADIENT_DITHER_RANDOM)
    {
        float nextValue = ceil(value * 255.0f) / 255.0f;
        float diff = abs(value - nextValue);

        value = (diff <= rand(fragPixelPos, randomSeed) / 255.0f) ? value : nextValue;
    }
    else if (g.z == GRADIENT_DITHER_ORDERED)
    {
        if (abs(trunc(value * 255.0f) - ceil(value * 255.0f)) > 1.0f/255.0f)
            value = orderedDither(fragPixelPos, gradientOrderedMatrixFlat, gradientOrderedMatrixFlatSize, value, false);
    }

    return value;

}




void main()
{
    vec2 fragPixelPos = gl_FragCoord.xy;
    
    // //vec2 texCoord = gl_FragCoord.xy * pixelSize;
    // //texCoord = vec2(texCoord.x, 1.0 - texCoord.y);
    // 
    // vec2 texCoord = gl_TexCoord[0].xy;
    // 
    // vec4 texPixelColor = texture2D(texture, texCoord);

    vec4 texPixelColor = getTexPixelColor(fragPixelPos);
            
    float gray = processColor(texPixelColor);
    
    vec4 fragColor = vec4(0, 0, 0, 1);

    float onebitvalue = -1;
    bool onebitblankedCalculated = false;

    for(int color = 0; color < 3; color++)
    {
    
        if (channelSource[color] == CHANNEL_SOURCE_MIN)
        {
            fragColor[color] = gradientParams[color].x;
        }
        else if (channelSource[color] == CHANNEL_SOURCE_MAX)
        {
            fragColor[color] = gradientParams[color].y;
        }
        else if (channelSource[color] == CHANNEL_SOURCE_GRAY)
        {
            if (gray > grayThreshWhite)
                gray = 1;
            else if (gray < grayThreshBlack)
                gray = 0;

            fragColor[color] = gray;
        
            fragColor.a = 1;
        }
        else if (channelSource[color] == CHANNEL_SOURCE_X)
        {
            fragColor[color] = getGradient(fragPixelPos, color, true);
        }
        else if (channelSource[color] == CHANNEL_SOURCE_Y)
        {
            fragColor[color] = getGradient(fragPixelPos, color, false);
        }
        else
        {
            fragColor[color] = 0;
        }


        if (oneBitEnabled[color] == 1)
        {
            if (onebitblankedCalculated)
            {
                if (onebitvalue > -1)
                    fragColor[color] = onebitvalue;
            }
            else
            {
                bool blankedPixel = isPixelBlanked(fragPixelPos, gray);
    
                if (blankedPixel)
                {
                    bool swapped = getOneBitSwappedDirection(fragPixelPos);
                    fragColor[color] = getOneBitLevel(fragPixelPos, swapped, pixelSize);
                    onebitvalue = fragColor[color];
                }
                onebitblankedCalculated = true;
            }

        }

    }// /for color


    gl_FragColor = fragColor; 
}