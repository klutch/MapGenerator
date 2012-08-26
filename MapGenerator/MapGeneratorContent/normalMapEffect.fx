sampler baseSampler : register(s0);
sampler normalSampler : register(s1);
float3 lightDirection;
float3 lightColor;
float3 lightAmbientColor;

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
    // Look up the texture and normalmap values.
    float4 tex = tex2D(baseSampler, texCoords);
    float3 normal = (tex2D(normalSampler, texCoords) * 2 - 1);
    
    // Compute lighting.
    float lightAmount = max(dot(normal, normalize(lightDirection)), 0);

	float4 color = tex;
	color.rgb = color.rgb * float3(lightAmount, lightAmount, lightAmount) * lightColor + lightAmbientColor;
    
    return color;
}

technique Main
{
    pass Normal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
