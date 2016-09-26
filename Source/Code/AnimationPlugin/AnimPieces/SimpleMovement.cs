using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class SimpleMovement : IAnimPiece
	{
		public Vector2 StartPos { get; set; }
		public Vector2 EndPos { get; set; }
		public bool Smoothing { get; set; }
        public bool Relative { get; set; }

        private Vector2 lastPos { get; set; }

		public void Tick (float percent, GameObject gameObject)
		{
            Vector2 pos = Vector2.Lerp (StartPos, EndPos, Smoothing ? Utilities.Smoothstep (percent) : percent);
            if (Relative) {
                gameObject.Transform?.MoveBy (pos - lastPos);
                lastPos = pos;
            } else {
                gameObject.Transform?.MoveTo (pos);
            }			
		}

		public void Initialize () { }
	}
}
