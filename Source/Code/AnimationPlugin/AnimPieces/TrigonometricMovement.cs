using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class TrigonometricMovement : IAnimPiece
	{
		private Vector2 lastPos;
		public Vector2 Frequency { get; set; }
		public Vector2 Amplitude { get; set; }
		public Vector2 Phase { get; set; }
		public bool Relative { get; set; }

		public void Initialize ()
		{
		}

		public void Tick (float percent, GameObject gameObject)
		{
			var pos = new Vector2 (
				Amplitude.X * MathF.Cos (percent * MathF.TwoPi * Frequency.X + Phase.X),
				Amplitude.Y * MathF.Sin (percent * MathF.TwoPi * Frequency.Y + Phase.Y)
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