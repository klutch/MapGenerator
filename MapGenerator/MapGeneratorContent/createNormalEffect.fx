sampler baseSampler : register(s0);
float2 renderTargetSize;
float normalStrength;

float4x4 matrixTransform;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	////////////////////////////////////////////
	// x00 - x10 - x20
	//  |     |     |
	// x01 - x11 - x21     x11 = base
	//  |     |     |
	// x02 - x12 - x22
	////////////////////////////////////////////
	float base = tex2D(baseSampler, texCoords).rgb;
	float3 normal = float3(0.5, 0.5, 1) * 2 - 1;

	// First sampling
	float x01 = (tex2D(baseSampler, texCoords + float2(4 / renderTargetSize.x, 0)).rgb * 2 - 1);
	float x10 = (tex2D(baseSampler, texCoords + float2(0, 4 / renderTargetSize.y)).rgb * 2 - 1);
	float x21 = (tex2D(baseSampler, texCoords + float2(-4 / renderTargetSize.x, 0)).rgb * 2 - 1);
	float x12 = (tex2D(baseSampler, texCoords + float2(0, -4 / renderTargetSize.y)).rgb * 2 - 1);

	// Second sampling
	x01 += (tex2D(baseSampler, texCoords + float2(6 / renderTargetSize.x, 0)).rgb * 2 - 1) / 2;
	x10 += (tex2D(baseSampler, texCoords + float2(0, 6 / renderTargetSize.y)).rgb * 2 - 1) / 2;
	x21 += (tex2D(baseSampler, texCoords + float2(-6 / renderTargetSize.x, 0)).rgb * 2 - 1) / 2;
	x12 += (tex2D(baseSampler, texCoords + float2(0, -6 / renderTargetSize.y)).rgb * 2 - 1) / 2;

	// Third sampling
	x01 += (tex2D(baseSampler, texCoords + float2(8 / renderTargetSize.x, 0)).rgb * 2 - 1) / 4;
	x10 += (tex2D(baseSampler, texCoords + float2(0, 8 / renderTargetSize.y)).rgb * 2 - 1) / 4;
	x21 += (tex2D(baseSampler, texCoords + float2(-8 / renderTargetSize.x, 0)).rgb * 2 - 1) / 4;
	x12 += (tex2D(baseSampler, texCoords + float2(0, -8 / renderTargetSize.y)).rgb * 2 - 1) / 4;

	// Fourth sampling
	x01 += (tex2D(baseSampler, texCoords + float2(10 / renderTargetSize.x, 0)).rgb * 2 - 1) / 4;
	x10 += (tex2D(baseSampler, texCoords + float2(0, 10 / renderTargetSize.y)).rgb * 2 - 1) / 4;
	x21 += (tex2D(baseSampler, texCoords + float2(-10 / renderTargetSize.x, 0)).rgb * 2 - 1) / 4;
	x12 += (tex2D(baseSampler, texCoords + float2(0, -10 / renderTargetSize.y)).rgb * 2 - 1) / 4;

	float u = (x01 - base) - (x21 - base);
	float v = (x10 - base) - (x12 - base);
	normal.r += u * normalStrength;
	normal.g += v * normalStrength;
	normal.rgb = (normal.rgb + 1) / 2;
	
	return float4(normal, 1);
}

technique Main
{
    pass CreateNormal
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PixelShaderFunction();
    }
}
