using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class SimpleMovement : IAnimPiece
	{
		public Vector2 StartPos { get; set; }
		public Vector2 EndPos { get; set; }
		public bool Smoothing { get; set; }

		public void Tick (float percent, GameObject gameObject)
		{
			gameObject.Transform?.MoveTo (Vector2.Lerp (StartPos, EndPos, Smoothing ? Utilities.Smoothstep (percent) : percent));
		}

		public void Initialize () { }
	}
}
