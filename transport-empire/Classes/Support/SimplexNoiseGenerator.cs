using SimplexNoise;

namespace TransportEmpire.Classes.Support
{
	internal class SimplexNoiseGenerator
	{
		public static float[,] Generate(int seed, int mapWidth, int mapHeight, float scale)
		{
			Noise.Seed = seed;

			return Noise.Calc2D(mapWidth, mapHeight, scale);
		}
	}
}
