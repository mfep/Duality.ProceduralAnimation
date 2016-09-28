using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class PathFollowMovement : IAnimPiece
	{
		public Vector2[] PathVertices { get; set; }
		public bool ConstantVelocity { get; set; }
        public bool Relative { get; set; }
        public bool Closed { get; set; }
        public bool Smoothing { get; set; }

        private RawList<Vector2> pathVertices;
		private Segment[] segments;
        private Vector2 lastPos;

		public void Tick (float percent, GameObject gameObject)
		{
		    if (Smoothing) percent = Utilities.Smoothstep(percent);
		    foreach (var currSegment in segments)
		    {
		        if (!(percent < currSegment.EndPercent)) continue;
		        var currPercent = (percent - currSegment.StartPercent) / (currSegment.EndPercent - currSegment.StartPercent);
		        var pos = Vector2.Lerp (currSegment.StartPos, currSegment.EndPos, currPercent);
		        if (Relative) {
		            gameObject.Transform?.MoveBy (pos - lastPos);
		            lastPos = pos;
		        } else {
		            gameObject.Transform?.MoveTo (pos);
		        }					
		        break;
		    }
		}

		public void Initialize ()
		{
			if (PathVertices == null) {
				Log.Core.WriteError ("PathVertices should not be null!");
				return;
			}
            pathVertices = new RawList<Vector2> (PathVertices);
            if (Closed) {
                Close ();
            }            
			CalculateSegments ();
		}

		private void CalculateSegments ()
		{
			segments = new Segment[pathVertices.Count - 1];
			float totalLength = CalculateTotalLength (pathVertices);
			float accSegmentLength = 0.0f;

			for (int index = 0; index < segments.Length; index++) {
				var beginPos = pathVertices[index];
				var endPos = pathVertices[index + 1];

				float currentSegmentLength = ConstantVelocity ?
					(beginPos - endPos).Length / totalLength
					: 1.0f / segments.Length;

				segments[index] = new Segment
				{
					StartPercent = accSegmentLength,
					EndPercent = accSegmentLength + currentSegmentLength,
					StartPos = beginPos,
					EndPos = endPos
				};

				accSegmentLength += currentSegmentLength;
			}
		}

        private void Close ()
        {
            if (pathVertices[0] != pathVertices[pathVertices.Count - 1]) {
                pathVertices.Add (pathVertices[0]);
            }
        }

		private static float CalculateTotalLength (RawList<Vector2> vertices)
		{
			float length = 0.0f;
			for (int index = 0; index < vertices.Count - 1; ++index) {
				length += (vertices[index] - vertices[index + 1]).Length;
			}
			return length;
		}

		private struct Segment
		{
			public float StartPercent { get; set; }
			public Vector2 StartPos { get; set; }
			public float EndPercent { get; set; }
			public Vector2 EndPos { get; set; }
		}
	}
}
