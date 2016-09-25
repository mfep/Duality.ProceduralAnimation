using Duality;

namespace MFEP.Duality.Plugins.Animation
{
	static internal class Utilities
	{
		static public float Smoothstep (float x)		
			=> x * x * (3.0f - 2.0f * x);
	}
}
