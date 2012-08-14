sampler baseSampler : register(s0);
float waterLevel;

float4 PSWater(float2 texCoords:TEXCOORD0) : COLOR0
{
    float4 base = tex2D(baseSampler, texCoords);
	float total = (base.r + base.g + base.b) / 3;
	return total > waterLevel ? base : float4(0, 0, 0.5, 1);
}

technique Water
{
    pass Base
    {
        PixelShader = compile ps_2_0 PSWater();
    }
}
