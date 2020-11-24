uniform sampler2D texture;

uniform bool incolorsgrayscale;
uniform vec3 incolorsinvert;
uniform vec3 incolorskoeff;

uniform vec3 outcolorsinvert;
uniform vec3 outcolorskoeff;
uniform float outgamma;

vec4 gammaCorrect(vec4 colors, float gamma)
{
    colors.r = pow(colors.r, 1.0f / gamma);
    colors.g = pow(colors.g, 1.0f / gamma);
    colors.b = pow(colors.b, 1.0f / gamma);

    return colors;
    
    // for 0-255: 255 * pow(c / 255, 1 / gamma);
}

vec4 invertByMask(vec4 colors, vec3 invertMask)
{
    colors.r = (invertMask.r == 0 ? colors.r : 1 - colors.r);
    colors.g = (invertMask.g == 0 ? colors.g : 1 - colors.g);
    colors.b = (invertMask.b == 0 ? colors.b : 1 - colors.b);

    return colors;
}


void main()
{
    vec4 pixel_color = texture2D(texture, gl_TexCoord[0].xy);

    pixel_color = invertByMask(pixel_color, incolorsinvert);
    
    pixel_color *= incolorskoeff;

    if (incolorsgrayscale)
    {
        float gray = pixel_color.r + pixel_color.g + pixel_color.b;

        pixel_color.r = gray;
        pixel_color.g = gray;
        pixel_color.b = gray;
    }

    pixel_color = invertByMask(pixel_color, outcolorsinvert);

    pixel_color *= outcolorskoeff;

    pixel_color = gammaCorrect(pixel_color, outgamma);


    gl_FragColor = pixel_color; 
}