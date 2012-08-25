sampler baseSampler : register(s0);
sampler normalSampler : register(s1);
float3 lightDirection = float3(0.2, 0.2, 1);

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
    // Look up the texture and normalmap values.
    float4 tex = tex2D(baseSampler, texCoords);
    float3 normal = (tex2D(normalSampler, texCoords) * 2 - 1);
    
    // Compute lighting.
    float lightAmount = max(dot(normal, normalize(lightDirection)), 0);
    
    return tex * lightAmount;
}

technique Main
{
    pass Normal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
