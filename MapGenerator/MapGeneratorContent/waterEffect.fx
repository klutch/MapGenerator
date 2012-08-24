#include <helper.fx>

sampler baseSampler : register(s0);
float waterLevel;
float4 color;

float4 PSWater(float2 texCoords:TEXCOORD0) : COLOR0
{
    float4 base = tex2D(baseSampler, texCoords);
	float total = base.rgb;
	float4 result = color;
	result.a = 0;

	if (total <= waterLevel)
	{
		result.a += (waterLevel - total) * 8;
		result.a += 0.1;
	}

	return result;
}

technique Water
{
    pass Base
    {
        PixelShader = compile ps_2_0 PSWater();
    }
}
