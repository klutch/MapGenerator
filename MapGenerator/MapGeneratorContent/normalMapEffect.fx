sampler baseSampler : register(s0);
sampler normalSampler : register(s1);
float3 lightDirection = float3(0.25, 0.25, 0.5);
float3 lightColor = float3(0.8, 0.8, 0.8);
float3 ambientColor = float3(0.8, 0.8, 0.8);

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
    float4 base = tex2D(baseSampler, texCoords);
	float3 normal = tex2D(normalSampler, texCoords);
	float lightAmount = max(dot(normal, lightDirection), 0);
	base.rgb *= ambientColor + lightAmount * lightColor;
	return base;
}

technique Main
{
    pass Normal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
