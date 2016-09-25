using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class PathFollowMovement : IAnimPiece
	{
		public Vector2[] PathVertices { get; set; }
		public bool ConstantVelocity { get; set; }

		private Segment[] segments;

		public void Tick (float percent, GameObject gameObject)
		{
			for (int index = 0; index < segments.Length; index++) {
				var currSegment = segments[index];
				if (percent < currSegment.EndPercent) {
					var currPercent = (percent - currSegment.StartPercent) / (currSegment.EndPercent - currSegment.StartPercent);
					var pos = Vector2.Lerp (currSegment.StartPos, currSegment.EndPos, currPercent);
					gameObject.Transform.MoveTo (pos);
					break;
				}
			}
		}

		public void Initialize ()
		{
			if (PathVertices == null) {
				Log.Core.WriteError ("PathVertices should not be null!");
				return;
			}
			CalculateSegments ();
		}

		private void CalculateSegments ()
		{
			segments = new Segment[PathVertices.Length - 1];
			float totalLength = CalculateTotalLength (PathVertices);
			float accSegmentLength = 0.0f;

			for (int index = 0; index < segments.Length; index++) {
				var beginPos = PathVertices[index];
				var endPos = PathVertices[index + 1];

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

		private static float CalculateTotalLength (Vector2[] vertices)
		{
			float length = 0.0f;
			for (int index = 0; index < vertices.Length - 1; ++index) {
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
