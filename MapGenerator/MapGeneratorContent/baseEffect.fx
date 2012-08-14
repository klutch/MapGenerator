sampler baseSampler : register(s0);

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	return base;
}

technique Main
{
    pass Base
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
