using Duality;
using static Duality.MathF;

namespace MFEP.Duality.Plugins.Animation
{
	public static class Utils
	{
		public delegate float SignalGen (float x);

		/// <summary>
		///     f(x) = 1
		/// </summary>
		public static SignalGen Const1 => x => 1.0f;

		/// <summary>
		///     f(x) = x
		/// </summary>
		public static SignalGen Unity => x => x;

		/// <summary>
		///     f(x) = 3x^2 - 2x^3
		/// </summary>
		public static SignalGen SmoothStep => x => x * x * (3.0f - 2.0f * x);

		/// <summary>
		///     f(x) = sin(2πx)
		/// </summary>
		public static SignalGen SimpleSin => x => MathF.Sin (TwoPi * x);

		/// <summary>
		///     f(x) = cos(2πx)
		/// </summary>
		public static SignalGen SimpleCos => x => MathF.Cos (TwoPi * x);

		/// <summary>
		///     f(x) = |sin(2πx)|
		/// </summary>
		public static SignalGen AbsSin => x => Abs (MathF.Sin (TwoPi * x));

		/// <summary>
		///     f(x) = |cos(2πx)|
		/// </summary>
		public static SignalGen AbsCos => x => Abs (MathF.Cos (TwoPi * x));

		/// <summary>
		///     f(x) = c
		/// </summary>
		/// <param name="constValue">c</param>
		public static SignalGen Const (float constValue) => x => constValue;

		/// <summary>
		///     f(x) = ax + b
		/// </summary>
		/// <param name="multiplier">a</param>
		/// <param name="offset">b</param>
		public static SignalGen Linear (float multiplier, float offset = 0.0f) => x => offset + x * multiplier;

		/// <summary>
		///     f(x) = x^n
		/// </summary>
		/// <param name="exponent">n</param>
		public static SignalGen Polinomial (float exponent) => x => Pow (x, exponent);

		/// <summary>
		///     f(x) = (e^(sx) - 1) / (e^s - 1)
		/// </summary>
		/// <param name="slope">s</param>
		public static SignalGen ExponentialGrow (float slope = 1.0f) => x => (Exp (x * slope) - 1) / (Exp (slope) - 1);

		/// <summary>
		///     f(x) = - (e^(sx) - 1) / (e^s - 1) + 1
		/// </summary>
		/// <param name="slope">s</param>
		public static SignalGen ExponentialDecr (float slope = 1.0f) => x => -1.0f * ExponentialGrow (slope) (x) + 1.0f;

		/// <summary>
		///     f(x) = sin(2πfx + φ) + c
		/// </summary>
		/// <param name="freq">f</param>
		/// <param name="amp">A</param>
		/// <param name="phase">φ</param>
		/// <param name="offset">c</param>
		public static SignalGen Sin (float freq, float amp = 1.0f, float phase = 0.0f, float offset = 0.0f)
			=> x => offset + amp * MathF.Sin (x * freq * TwoPi + phase);

		/// <summary>
		///     f(x) = cos(2πfx + φ) + c
		/// </summary>
		/// <param name="freq">f</param>
		/// <param name="amp">A</param>
		/// <param name="phase">φ</param>
		/// <param name="offset">c</param>
		public static SignalGen Cos (float freq, float amp = 1.0f, float phase = 0.0f, float offset = 0.0f)
			=> x => offset + amp * MathF.Cos (x * freq * TwoPi + phase);
	}
}