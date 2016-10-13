using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Provides more advanced controls over the trigonometric functions which move the gameObject. Simpler version is
	///     EllipseMovement.
	///     Consists of two trigonometric expression: one in the X, one in the Y direction.
	/// </summary>
	public class TrigonometricMovement2D : IAnimPiece
	{
		private Vector2 lastPos;

		/// <summary>
		///     The 'speed' of the trigonometric functions in the X and Y directions.
		///     The frequency of 1 means one period over the animation.
		///     Default is Vector2.One
		/// </summary>
		public Vector2 Frequency { get; set; } = Vector2.One;

		/// <summary>
		///     Frequency multiplier function in the X direction.
		///     Default is Const1
		/// </summary>
		public SignalGen FreqGenX { get; set; } = Const1;

		/// <summary>
		///     Frequency multiplier function in the Y direction.
		///     Default is Const1
		/// </summary>
		public SignalGen FreqGenY { get; set; } = Const1;

		/// <summary>
		///     The magnitude of the movement in X and Y direction.
		///     Default is Vector2 (200f, 200f)
		/// </summary>
		public Vector2 Amplitude { get; set; } = Vector2.One * 200.0f;

		/// <summary>
		///     Amplitude multiplier function in the X direction.
		///     Default is Const1
		/// </summary>
		public SignalGen AmpGenX { get; set; } = Const1;

		/// <summary>
		///     Amplitude multiplier function in the Y direction.
		///     Default is Const1
		/// </summary>
		public SignalGen AmpGenY { get; set; } = Const1;

		/// <summary>
		///     The phase of the trigonometric expression in X and Y direction.
		///     Default is Vector2.Zero
		/// </summary>
		public Vector2 Phase { get; set; }

		/// <summary>
		///     Phase multiplier function in the X direction.
		/// </summary>
		public SignalGen PhaseGenX { get; set; } = Const1;

		/// <summary>
		///     Phase multiplier function in the Y direction.
		/// </summary>
		public SignalGen PhaseGenY { get; set; } = Const1;

		/// <summary>
		///     Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space.
		///     Default is true
		/// </summary>
		public bool Relative { get; set; } = true;

		public void Initialize ()
		{
		}

		public void Tick (float pc, GameObject gameObject)
		{
			var pos = new Vector2 (
				AmpGenX (pc) * Amplitude.X * MathF.Cos (pc * MathF.TwoPi * Frequency.X * FreqGenX (pc) + Phase.X * PhaseGenX (pc)),
				AmpGenY (pc) * Amplitude.Y * MathF.Sin (pc * MathF.TwoPi * Frequency.Y * FreqGenY (pc) + Phase.Y * PhaseGenY (pc))
			);

			if (Relative) {
				gameObject.Transform?.MoveBy (pos - lastPos);
				lastPos = pos;
			} else {
				gameObject.Transform?.MoveTo (pos);
			}
		}
	}
}