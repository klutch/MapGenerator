#include <helper.fx>

sampler baseSampler : register(s0);
float waterLevel;
float4 shallowColor;
float4 deepColor;

float4 PSWater(float2 texCoords:TEXCOORD0) : COLOR0
{
    float4 base = tex2D(baseSampler, texCoords);
	float total = base.rgb;
	float4 result = shallowColor;
	result.a = 0;

	if (total <= waterLevel)
	{
		float value = ((waterLevel - total) * 8) + 0.4;
		result.a += value;
		result.rgb = lerp(shallowColor.rgb, deepColor.rgb, value);
		//result.rgb -= result.a / 2;
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
