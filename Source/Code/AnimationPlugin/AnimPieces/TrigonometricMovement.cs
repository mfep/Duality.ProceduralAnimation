using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class TrigonometricMovement : IAnimPiece
	{
		private Vector2 lastPos;
		public Vector2 Frequency { get; set; } = Vector2.One;
		public SignalGen FreqGenX { get; set; } = Const1;
		public SignalGen FreqGenY { get; set; } = Const1;
		public Vector2 Amplitude { get; set; } = Vector2.One * 200.0f;
		public SignalGen AmpGenX { get; set; } = Const1;
		public SignalGen AmpGenY { get; set; } = Const1;
		public Vector2 Phase { get; set; }
		public SignalGen PhaseGenX { get; set; } = Const1;
		public SignalGen PhaseGenY { get; set; } = Const1;
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