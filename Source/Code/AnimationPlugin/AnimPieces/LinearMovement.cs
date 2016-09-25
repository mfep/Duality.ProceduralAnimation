using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class LinearMovement : IAnimPiece
	{
		public Vector2 StartPos { get; set; }
		public Vector2 EndPos { get; set; }

		public void Tick (float percent, GameObject gameObject)
		{
			gameObject.Transform.MoveTo (Vector2.Lerp (StartPos, EndPos, percent));
		}

		public void Initialize () { }
	}
}
