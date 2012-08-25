sampler baseSampler : register(s0);
float2 renderTargetSize;

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
	float3 normal = float3(0.5, 0.5, 1);

	// First sampling
	float x01 = tex2D(baseSampler, texCoords + float2(2 / renderTargetSize.x, 0)).rgb / 2;
	float x10 = tex2D(baseSampler, texCoords + float2(0, 2 / renderTargetSize.y)).rgb / 2;
	float x21 = tex2D(baseSampler, texCoords + float2(-2 / renderTargetSize.x, 0)).rgb / 2;
	float x12 = tex2D(baseSampler, texCoords + float2(0, -2 / renderTargetSize.y)).rgb / 2;

	// Second sampling
	x01 += tex2D(baseSampler, texCoords + float2(4 / renderTargetSize.x, 0)).rgb / 4;
	x10 += tex2D(baseSampler, texCoords + float2(0, 4 / renderTargetSize.y)).rgb / 4;
	x21 += tex2D(baseSampler, texCoords + float2(-4 / renderTargetSize.x, 0)).rgb / 4;
	x12 += tex2D(baseSampler, texCoords + float2(0, -4 / renderTargetSize.y)).rgb / 4;

	// Third sampling
	x01 += tex2D(baseSampler, texCoords + float2(8 / renderTargetSize.x, 0)).rgb / 8;
	x10 += tex2D(baseSampler, texCoords + float2(0, 8 / renderTargetSize.y)).rgb / 8;
	x21 += tex2D(baseSampler, texCoords + float2(-8 / renderTargetSize.x, 0)).rgb / 8;
	x12 += tex2D(baseSampler, texCoords + float2(0, -8 / renderTargetSize.y)).rgb / 8;

	// Fourth sampling
	x01 += tex2D(baseSampler, texCoords + float2(16 / renderTargetSize.x, 0)).rgb / 8;
	x10 += tex2D(baseSampler, texCoords + float2(0, 16 / renderTargetSize.y)).rgb / 8;
	x21 += tex2D(baseSampler, texCoords + float2(-16 / renderTargetSize.x, 0)).rgb / 8;
	x12 += tex2D(baseSampler, texCoords + float2(0, -16 / renderTargetSize.y)).rgb / 8;

	float u = (x01 - base) - (x21 - base);
	float v = (x10 - base) - (x12 - base);
	normal.r += u;
	normal.g += v;
	
	return float4(normal, 1);
}

technique Main
{
    pass CreateNormal
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
