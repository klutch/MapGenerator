sampler baseSampler : register(s0);
float waterLevel;

float4 PSWater(float2 texCoords:TEXCOORD0) : COLOR0
{
    float4 base = tex2D(baseSampler, texCoords);
	float total = base.rgb;
	float4 result = total > waterLevel - 0.03 ? float4(0, 0, 0, 0) : float4(0, 0, 0, 1);
	result += total > (waterLevel + 0.01) ? float4(0, 0, 0, 0) : float4(0, 0, 0.1, 0.1);
	result += total > (waterLevel + 0.02) ? float4(0, 0, 0, 0) : float4(0, 0, 0.1, 0.1);
	result += total > (waterLevel + 0.03) ? float4(0, 0, 0, 0) : float4(0, 0, 0.1, 0.1);
	return result;
}

technique Water
{
    pass Base
    {
        PixelShader = compile ps_2_0 PSWater();
    }
}
