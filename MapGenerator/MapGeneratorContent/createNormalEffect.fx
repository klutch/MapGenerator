sampler baseSampler : register(s0);
float2 renderTargetSize;

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);

	float val = tex2D(baseSampler, texCoords);
	float valU = tex2D(baseSampler, texCoords - float2(4 / renderTargetSize.x, 0)) / 3;
	valU += tex2D(baseSampler, texCoords - float2(8 / renderTargetSize.x, 0)) / 3;
	valU += tex2D(baseSampler, texCoords - float2(16 / renderTargetSize.x, 0)) / 3;
	float valV = tex2D(baseSampler, texCoords - float2(0, 8 / renderTargetSize.y)) / 3;
	valV += tex2D(baseSampler, texCoords - float2(0, 16 / renderTargetSize.y)) / 3;
	valV += tex2D(baseSampler, texCoords - float2(0, 32 / renderTargetSize.y)) / 3;

	float3 normal = normalize(float3(val - valU, 0.01, val - valV));
	return float4(normal, 1);
}

technique Main
{
    pass CreateNormal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
