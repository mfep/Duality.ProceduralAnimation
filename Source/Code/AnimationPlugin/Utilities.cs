namespace MFEP.Duality.Plugins.Animation
{
	internal static class Utilities
	{
		public static float Smoothstep (float x)		
			=> x * x * (3.0f - 2.0f * x);
	}
}
