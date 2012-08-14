sampler baseSampler : register(s0) = sampler_state
{
	AddressU = Wrap;
	AddressV = Wrap;
};

float2 randomTextureSize;
float2 renderTargetSize;

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords * (renderTargetSize / randomTextureSize));
	return base;
}

technique Main
{
    pass Base
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
