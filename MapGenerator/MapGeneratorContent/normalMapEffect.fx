sampler baseSampler : register(s0);
sampler normalSampler : register(s1);
bool light1;
float3 light1Direction;
float3 light1Color;
float3 light1AmbientColor;
float light1Intensity;
bool light2;
float3 light2Direction;
float3 light2Color;
float3 light2AmbientColor;
float light2Intensity;

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
    // Look up the texture and normalmap values.
    float4 tex = tex2D(baseSampler, texCoords);
    float3 normal = (tex2D(normalSampler, texCoords) * 2 - 1);
	float lightAmount = 0;
    float3 totalLight = 0;

    // Compute lighting.
	if (light1)
	{
		lightAmount = max(dot(normal, normalize(light1Direction)), 0);
		totalLight += float3(lightAmount, lightAmount, lightAmount) * light1Color * light1Intensity + light1AmbientColor;
	}
	if (light2)
	{
		lightAmount = max(dot(normal, normalize(light2Direction)), 0);
		totalLight += float3(lightAmount, lightAmount, lightAmount) * light2Color * light2Intensity + light2AmbientColor;
	}

	tex.rgb *= totalLight;
    
    return tex;
}

technique Main
{
    pass Normal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
