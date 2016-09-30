using Duality;
using static Duality.MathF;

namespace MFEP.Duality.Plugins.Animation
{
	public static class Utils
	{
		public delegate float SignalGen (float x);

		public static SignalGen Const1 => x => 1.0f;
		public static SignalGen Unity => x => x;
		public static SignalGen SmoothStep => x => x * x * (3.0f - 2.0f * x);
		public static SignalGen SimpleSin => x => MathF.Sin (TwoPi * x);
		public static SignalGen SimpleCos => x => MathF.Cos (TwoPi * x);
		public static SignalGen AbsSin => x => Abs (MathF.Sin (TwoPi * x));
		public static SignalGen AbsCos => x => Abs (MathF.Cos (TwoPi * x));

		public static SignalGen Const (float constValue) => x => constValue;
		public static SignalGen Linear (float multiplier, float offset = 0.0f) => x => offset + x * multiplier;
		public static SignalGen Polinomial (float exponent) => x => Pow (x, exponent);
		public static SignalGen Exponential (float slope = 1.0f) => x => (Exp (x * slope) - 1) / (Exp (slope) - 1);

		public static SignalGen Sin (float freq, float amp = 1.0f, float phase = 0.0f, float offset = 0.0f)
			=> x => offset + amp * MathF.Sin (x * freq * TwoPi + phase);

		public static SignalGen Cos (float freq, float amp = 1.0f, float phase = 0.0f, float offset = 0.0f)
			=> x => offset + amp * MathF.Cos (x * freq * TwoPi + phase);
	}
}