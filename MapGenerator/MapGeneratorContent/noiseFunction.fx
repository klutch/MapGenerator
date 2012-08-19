// Worley table
float2 worleyTable[] =
{
	float2(0.92495, 0.4217),
	float2(0.72405, 0.40145),
	float2(0.48187, 0.15453),
	float2(0.40469, 0.07647),
	float2(0.91161, 0.45044),
	float2(0.28146, 0.16623),
	float2(0.21131, 0.79345),
	float2(0.14815, 0.32878),
	float2(0.35197, 0.10551),
	float2(0.60736, 0.56258),
	float2(0.58473, 0.83933),
	float2(0.16503, 0.15542),
	float2(0.20381, 0.90046),
	float2(0.625, 0.36297),
	float2(0.45304, 0.41343),
	float2(0.46643, 0.29033),
	float2(0.52897, 0.8642),
	float2(0.68678, 0.21863),
	float2(0.07115, 0.30072),
	float2(0.1356, 0.73858),
	float2(0.13423, 0.27875),
	float2(0.31267, 0.35462),
	float2(0.74664, 0.96859),
	float2(0.36247, 0.55387),
	float2(0.89025, 0.19547),
	float2(0.47945, 0.62946),
	float2(0.47238, 0.96351),
	float2(0.20143, 0.08003),
	float2(0.48131, 0.51847),
	float2(0.3771, 0.15157),
	float2(0.22699, 0.89091),
	float2(0.3373, 0.10518)
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
float worley(float2 position)
{
	float shortestDistance = 1;
	for (int i = 0; i < 32; i++)
	{
		float2 diff = worleyTable[i] - position;
		diff *= 2;
		float distance = sqrt(diff.x * diff.x + diff.y * diff.y);
		shortestDistance = min(shortestDistance, distance);
	}
	return 1 - shortestDistance;
}