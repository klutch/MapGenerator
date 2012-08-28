// weight: f(x) = 6x^5 - 15x^4 + 10x^3
float weight(float x)
{
	return 6 * pow(x, 5) - 15 * pow(x, 4) + 10 * pow(x, 3);
}

// noise2D
float2 noiseSize;
float2 noiseOffset;
float noiseScale;
float2 renderSize;

float noise2D(sampler noiseSampler, float2 position)
{
	// Transform position
	float2 p = (position * float2(1, renderSize.y / renderSize.x) - noiseOffset / renderSize) / noiseScale;

	// Scale texture coordinates from [0, 1] to [0, textureSize]
	float2 realPosition = p * noiseSize;

	// Grid points
	int x0 = floor(realPosition.x);
	int y0 = floor(realPosition.y);
	int x1 = x0 + 1;
	int y1 = y0 + 1;

	// Gradients
	float2 g00 = tex2D(noiseSampler, float2(x0, y0) / noiseSize).rg * 2 - 1;
	float2 g10 = tex2D(noiseSampler, float2(x1, y0) / noiseSize).rg * 2 - 1;
	float2 g01 = tex2D(noiseSampler, float2(x0, y1) / noiseSize).rg * 2 - 1;
	float2 g11 = tex2D(noiseSampler, float2(x1, y1) / noiseSize).rg * 2 - 1;

	// Position inside grid
	float u = realPosition.x - x0;
	float v = realPosition.y - y0;

	// Influence (dot product of gradient and distance to position from grid point)
	float n00 = dot(g00, float2(u, v));
	float n10 = dot(g10, float2(u - 1, v));
	float n01 = dot(g01, float2(u, v - 1));
	float n11 = dot(g11, float2(u - 1, v - 1));

	// Weighted contributions
	float nx0 = n00 * (1 - weight(u)) + n10 * weight(u);
	float nx1 = n01 * (1 - weight(u)) + n11 * weight(u);
	float nxy = nx0 * (1 - weight(v)) + nx1 * weight(v);

	return (nxy + 1) / 2;
}

// Worley noise
float lengthSq(float2 p)
{
	return p.x * p.x + p.y * p.y;
}
float worley(sampler worleySampler, float2 position)
{
	float shortestDistance = 1;
	for (int i = 0; i < 18; i++)
	{
		float2 source = tex2D(worleySampler, float2((i * 1.0) / 18.0, 0)).rg;
		float2 worleyPoint1 = source + floor(position);
		float2 worleyPoint2 = source + floor(position) + float2(0, -1);		// Top
		float2 worleyPoint3 = source + floor(position) + float2(1, -1);		// NE
		float2 worleyPoint4 = source + floor(position) + float2(1, 0);		// E
		float2 worleyPoint5 = source + floor(position) + float2(1, 1);		// SE
		float2 worleyPoint6 = source + floor(position) + float2(0, 1);		// S
		float2 worleyPoint7 = source + floor(position) + float2(-1, 1);		// SW
		float2 worleyPoint8 = source + floor(position) + float2(-1, 0);		// W
		float2 worleyPoint9 = source + floor(position) + float2(-1, -1);	// NW

		float distance1 = lengthSq(worleyPoint1 - position);
		float distance2 = lengthSq(worleyPoint2 - position);
		float distance3 = lengthSq(worleyPoint3 - position);
		float distance4 = lengthSq(worleyPoint4 - position);
		float distance5 = lengthSq(worleyPoint5 - position);
		float distance6 = lengthSq(worleyPoint6 - position);
		float distance7 = lengthSq(worleyPoint7 - position);
		float distance8 = lengthSq(worleyPoint8 - position);
		float distance9 = lengthSq(worleyPoint9 - position);

		shortestDistance = min(shortestDistance, distance1);
		shortestDistance = min(shortestDistance, distance2);
		shortestDistance = min(shortestDistance, distance3);
		shortestDistance = min(shortestDistance, distance4);
		shortestDistance = min(shortestDistance, distance5);
		shortestDistance = min(shortestDistance, distance6);
		shortestDistance = min(shortestDistance, distance7);
		shortestDistance = min(shortestDistance, distance8);
		shortestDistance = min(shortestDistance, distance9);
	}
	return 1 - shortestDistance * 8;
}