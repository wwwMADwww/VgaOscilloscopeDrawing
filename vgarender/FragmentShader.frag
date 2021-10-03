#version 130

uniform sampler2D texture;
uniform vec2 windowSize;

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


float rand(float seed) 
{
    return fract(sin(dot(gl_FragCoord.xy, vec2(12.9898, 4.1414))) * seed);
}


float getOneBitValue()
{

    if (oneBitSwapMode == ONEBIT_SWAP_NONE)
    {
        return oneBitTop;
    }
    else if (oneBitSwapMode == ONEBIT_SWAP_AFTER)
    {
        return (float(gl_FragCoord.x) / oneBitSwapAfter.x < windowSize.x) || (float(gl_FragCoord.y) / oneBitSwapAfter.y < windowSize.y)
            ? oneBitBottom
            : oneBitTop;
    }
    else if (oneBitSwapMode == ONEBIT_SWAP_CHECKERED)
    {
        float checkW = windowSize.x * oneBitSwapCheckered.x;
        float checkH = windowSize.y * oneBitSwapCheckered.y;

        int fx = int(float(gl_FragCoord.x) / checkW);
        int fy = int(float(gl_FragCoord.y) / checkH);

        if (mod(fx, 2) == 1)
            return mod(fy, 2) == 1 ? oneBitTop : oneBitBottom;
        else
            return mod(fy, 2) == 1 ? oneBitBottom : oneBitTop;
    }
    else if (oneBitSwapMode == ONEBIT_SWAP_RANDOM)
    {
        return rand(randomSeed * 2) > 0.5
            ? oneBitTop
            : oneBitBottom;
    }

    return -1;
}




float orderedIndexValue(float[256] matrixFlat, int matrixSize) 
{
    int x = int(mod(gl_FragCoord.x + orderedShift.x, matrixSize));
    int y = int(mod(gl_FragCoord.y + orderedShift.y, matrixSize));
    return matrixFlat[(x + y * matrixSize)] / float(matrixSize * matrixSize);
}

float orderedDither(float[256] matrixFlat, int matrixSize, float color, bool binary) 
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

    float d = orderedIndexValue(matrixFlat, matrixSize);
    float distance = abs(closestColor - color);
    return (distance < d) ? closestColor : secondClosestColor;
}



float getGradient(int channelId, bool horizontal)
{
    // vec3(startValue, endValue, GRADIENT_DITHER)
    vec3 g = gradientParams[channelId];

    float diff = g.y - g.x;
    float value = 0;

    if (horizontal)
    {
        value = g.x + diff * gl_FragCoord.x / windowSize.x;
    }
    else
    {
        value = g.x + diff * gl_FragCoord.y / windowSize.y;
    }

    if (g.z == GRADIENT_DITHER_NONE)
    {
        // nothing
    }
    else if (g.z == GRADIENT_DITHER_RANDOM)
    {
        float nextValue = ceil(value * 255.0f) / 255.0f;
        float diff = abs(value - nextValue);

        value = (diff <= rand(randomSeed) / 255.0f) ? value : nextValue;
    }
    else if (g.z == GRADIENT_DITHER_ORDERED)
    {
        if (abs(trunc(value * 255.0f) - ceil(value * 255.0f)) > 1.0f/255.0f)
            value = orderedDither(gradientOrderedMatrixFlat, gradientOrderedMatrixFlatSize, value, false);
    }

    return value;

}


void main()
{
    vec4 pixelColor = texture2D(texture, gl_TexCoord[0].xy);
    
    float gray = 
        pixelColor.r * grayColorRatio.r + 
        pixelColor.g * grayColorRatio.g + 
        pixelColor.b * grayColorRatio.b;

    if (colorInvert == 1)
        gray = 1.0 - gray;

    gray = gray * contrast;
    gray = gray + brightness;

    gray = gammaCorrect(gray, gamma);
    
    pixelColor = vec4(0, 0, 0, 1);

    for(int color = 0; color < 3; color++)
    {
    
        if (channelSource[color] == CHANNEL_SOURCE_MIN)
        {
            pixelColor[color] = gradientParams[color].x;
        }
        else if (channelSource[color] == CHANNEL_SOURCE_MAX)
        {
            pixelColor[color] = gradientParams[color].y;
        }
        else if (channelSource[color] == CHANNEL_SOURCE_GRAY)
        {
            if (gray > grayThreshWhite)
                gray = 1;
            else if (gray < grayThreshBlack)
                gray = 0;

            pixelColor[color] = gray;
        
            pixelColor.a = 1;
        }
        else if (channelSource[color] == CHANNEL_SOURCE_X)
        {
            pixelColor[color] = getGradient(color, true);
        }
        else if (channelSource[color] == CHANNEL_SOURCE_Y)
        {
            pixelColor[color] = getGradient(color, false);
        }
        else
        {
            pixelColor[color] = 0;
        }


        if (oneBitEnabled[color] == 1)
        {
            bool activePixel = false;
    
            if (gray > grayThreshWhite) 
            {
                activePixel = true;
            }
            else if (gray < grayThreshBlack) 
            {
                activePixel = false;
            }
            else if (oneBitEncodingMode == ONEBIT_RANDOM)
            {
                activePixel = gray > rand(randomSeed);
            }
            else if (oneBitEncodingMode == ONEBIT_ORDERED)
            {
                activePixel = orderedDither(orderedMatrixFlat, orderedMatrixFlatSize, gray, true) > 0.0;
            }
            else if (oneBitEncodingMode == ONEBIT_PWM)
            {
                activePixel = gray > pwmColor;
            }
    
            if (activePixel)
                pixelColor[color] = getOneBitValue();
        }

    }// /for color


    gl_FragColor = pixelColor; 
}