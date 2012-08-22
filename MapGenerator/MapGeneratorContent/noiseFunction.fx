// Worley table
float2 worleyTable[] =
{
	float2(0.09422, 0.10386),
	float2(0.37504, 0.03784),
	float2(0.64836, 0.03351),
	float2(0.88309, 0.03393),
	float2(0.18921, 0.28619),
	float2(0.42112, 0.3259),
	float2(0.63519, 0.43585),
	float2(0.83907, 0.27749),
	float2(0.0987, 0.66394),
	float2(0.41705, 0.64828),
	float2(0.71544, 0.55101),
	float2(0.90036, 0.64619),
	float2(0.20759, 0.84708),
	float2(0.37159, 0.92968),
	float2(0.70334, 0.83989),
	float2(0.96814, 0.78153)
};

// Noise
float noise(sampler noiseSampler, float2 position, float frequency, float gain, float lacunarity)
{
	float total = 0;
	float amplitude = gain;

	for (int i = 0; i < 8; i++)
	{
		total += tex2D(noiseSampler, position * frequency) * amplitude;
		frequency *= lacunarity;
		amplitude *= gain;

	}

	return total;
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
	return 1 - sqrt(shortestDistance * 4);
}