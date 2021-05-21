uniform sampler2D texture;

uniform bool blurVertical;
uniform float blurSize;

// https://en.wikipedia.org/wiki/Gaussian_blur
// https://web.archive.org/web/20141011040321/http://www.gamerendering.com/2008/10/11/gaussian-blur-filter-shader/


vec4 BlurHorizontal()
{
    vec2 texCoord = gl_TexCoord[0].xy;
    vec4 sum = vec4(0.0);

    sum += texture2D(texture, vec2(texCoord.x - 4.0*blurSize, texCoord.y)) * 0.05;
    sum += texture2D(texture, vec2(texCoord.x - 3.0*blurSize, texCoord.y)) * 0.09;
    sum += texture2D(texture, vec2(texCoord.x - 2.0*blurSize, texCoord.y)) * 0.12;
    sum += texture2D(texture, vec2(texCoord.x -     blurSize, texCoord.y)) * 0.15;
    sum += texture2D(texture, vec2(texCoord.x               , texCoord.y)) * 0.16;
    sum += texture2D(texture, vec2(texCoord.x +     blurSize, texCoord.y)) * 0.15;
    sum += texture2D(texture, vec2(texCoord.x + 2.0*blurSize, texCoord.y)) * 0.12;
    sum += texture2D(texture, vec2(texCoord.x + 3.0*blurSize, texCoord.y)) * 0.09;
    sum += texture2D(texture, vec2(texCoord.x + 4.0*blurSize, texCoord.y)) * 0.05;

    return sum;
}


vec4 BlurVertical()
{
    vec2 texCoord = gl_TexCoord[0].xy;
    vec4 sum = vec4(0.0);

    sum += texture2D(texture, vec2(texCoord.x, texCoord.y - 4.0*blurSize)) * 0.05;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y - 3.0*blurSize)) * 0.09;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y - 2.0*blurSize)) * 0.12;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y -     blurSize)) * 0.15;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y               )) * 0.16;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y +     blurSize)) * 0.15;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y + 2.0*blurSize)) * 0.12;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y + 3.0*blurSize)) * 0.09;
    sum += texture2D(texture, vec2(texCoord.x, texCoord.y + 4.0*blurSize)) * 0.05;

    return sum;
}


void main(void)
{
    vec4 sum = vec4(0.0);

    if (blurVertical)
        sum = BlurVertical();
    else
        sum = BlurHorizontal();

    gl_FragColor = sum;
}