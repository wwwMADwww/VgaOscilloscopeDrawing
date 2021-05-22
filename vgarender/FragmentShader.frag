#version 130

uniform sampler2D texture;
uniform vec2 windowSize;

uniform int activeChannel;

uniform vec3  grayColorRatio;
uniform float grayThreshBlack;
uniform float grayThreshWhite;
uniform float gamma;
uniform int   colorInvert;

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


uniform vec2      orderedShift;

uniform float pwmColor;

uniform float randomSeed;


const int ONEBIT_NONE    = 0;
const int ONEBIT_RANDOM  = 1;
const int ONEBIT_ORDERED = 2;
const int ONEBIT_PWM     = 3;

const int ONEBIT_SWAP_NONE       = 0;
const int ONEBIT_SWAP_AFTER      = 1;
const int ONEBIT_SWAP_CHECKERED  = 2;
const int ONEBIT_SWAP_RANDOM     = 3;



float gammaCorrect(float gray, float gamma)
{
    return pow(gray, 1.0f / gamma);
    // for 0-255: 255 * pow(c / 255, 1 / gamma);
}


float rand(float seed) {
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
            ? oneBitTop
            : oneBitBottom;
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




float orderedIndexValue() {
    int x = int(mod(gl_FragCoord.x + orderedShift.x, orderedMatrixFlatSize));
    int y = int(mod(gl_FragCoord.y + orderedShift.y, orderedMatrixFlatSize));
    return orderedMatrixFlat[(x + y * orderedMatrixFlatSize)] / float(orderedMatrixFlatSize * orderedMatrixFlatSize);
}

float orderedDither(float color) {
    float closestColor = (color < 0.5) ? 0 : 1;
    float secondClosestColor = 1 - closestColor;
    float d = orderedIndexValue();
    float distance = abs(closestColor - color);
    return (distance < d) ? closestColor : secondClosestColor;
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

    gray = gammaCorrect(gray, gamma);
    
    pixelColor = vec4(0, 0, 0, 0);
    
    if (oneBitEncodingMode == ONEBIT_NONE)
    {   
        if (gray > grayThreshWhite)
            gray = 1;
        else if (gray < grayThreshBlack)
            gray = 0;

        if (activeChannel == 0)
            pixelColor.r = gray;
        
        if (activeChannel == 1)
            pixelColor.g = gray;
        
        if (activeChannel == 2)
            pixelColor.b = gray;
        
        pixelColor.a = 1;

    }
    else 
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
            activePixel = orderedDither(gray) > 0.0;
        }
        else if (oneBitEncodingMode == ONEBIT_PWM)
        {
            activePixel = gray > pwmColor;
        }
    
        float level = getOneBitValue();

        if (activeChannel == 0)
            pixelColor.r = level;

        if (activeChannel == 1)
            pixelColor.g = level;

        if (activeChannel == 2)
            pixelColor.b = level;

        pixelColor.a = activePixel ? 1.0 : 0.0;
    }


    gl_FragColor = pixelColor; 
}