sampler baseSampler : register(s0);
sampler maskSampler : register(s1);
float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	float4 mask = tex2D(maskSampler, texCoords);
	base *= mask.a;
    return base;
}

technique Technique1
{
    pass Pass1
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
