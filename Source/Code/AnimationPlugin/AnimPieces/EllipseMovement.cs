using Duality;
using static Duality.MathF;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class EllipseMovement : IAnimPiece
	{
		private Vector2 lastPos;

		public float RadiusX { get; set; } = 200f;
		public float RadiusY { get; set; } = 200f;
		public float StartPhase { get; set; } = 0f;
		public float EndPhase { get; set; } = TwoPi;
		public bool Relative { get; set; } = true;

		public void Tick (float pc, GameObject gameObject)
		{
			var currentPhase = DegToRad (Lerp (StartPhase, EndPhase, pc));
			var newPos = new Vector2 (RadiusX * Cos (currentPhase), RadiusY * Sin (currentPhase));
			if (Relative) {
				gameObject.Transform.MoveBy (newPos - lastPos);
				lastPos = newPos;
			} else {
				gameObject.Transform.MoveTo (newPos);
			}
		}

		public void Initialize ()
		{
		}
	}
}