sampler baseSampler : register(s0);
float4x4 matrixTransform;
float4 noiseLowColor;
float4 noiseHighColor;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSBaseNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	float value = 0;
	float4 base = tex2D(baseSampler, texCoords);
	value = (base.r + base.g + base.b) / 3;
	return lerp(noiseLowColor, noiseHighColor, value);
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseNoise();
    }
}
