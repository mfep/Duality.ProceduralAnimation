using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class SimpleMovement : IAnimPiece
	{
		public Vector2 StartPos { get; set; }
		public Vector2 EndPos { get; set; }
		public SignalGen PosGen { get; set; } = Unity;
		public bool Relative { get; set; } = true;

		private Vector2 lastPos { get; set; }

		public void Tick (float pc, GameObject gameObject)
		{
			var pos = Vector2.Lerp (StartPos, EndPos, PosGen (pc));
			if (Relative) {
				gameObject.Transform?.MoveBy (pos - lastPos);
				lastPos = pos;
			} else {
				gameObject.Transform?.MoveTo (pos);
			}
		}

		public void Initialize ()
		{
		}
	}
}