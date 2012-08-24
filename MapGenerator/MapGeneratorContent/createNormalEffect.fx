sampler baseSampler : register(s0);
float2 renderTargetSize;

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	float normY = 0.1;
	float3 normal = float3(0, normY, 0);
	normal.x -= tex2D(baseSampler, texCoords + float2(-2 / renderTargetSize.x, 0)) / 2;
	normal.x += tex2D(baseSampler, texCoords + float2(2 / renderTargetSize.x, 0)) / 2;
	normal.z -= tex2D(baseSampler, texCoords + float2(0, -2 / renderTargetSize.y)) / 2;
	normal.z += tex2D(baseSampler, texCoords + float2(0, 2 / renderTargetSize.y)) / 2;
	normal.x -= tex2D(baseSampler, texCoords + float2(-1 / renderTargetSize.x, 0)) / 2;
	normal.x += tex2D(baseSampler, texCoords + float2(1 / renderTargetSize.x, 0)) / 2;
	normal.z -= tex2D(baseSampler, texCoords + float2(0, -1 / renderTargetSize.y)) / 2;
	normal.z += tex2D(baseSampler, texCoords + float2(0, 1 / renderTargetSize.y)) / 2;
	normal = normalize(normal);
	normal.rgb = normal.rbg;
    return float4(normal, 1);
}

technique Main
{
    pass CreateNormal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
