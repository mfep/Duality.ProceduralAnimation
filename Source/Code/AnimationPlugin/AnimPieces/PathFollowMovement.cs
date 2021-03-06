﻿using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Moves the animated GameObject along a preinitialized path. The path consists of the segments between the
	///     PathVertices.
	/// </summary>
	public class PathFollowMovement : IAnimPiece
	{
		private Vector2 lastPos;

		private RawList<Vector2> pathVertices;
		private Segment[] segments;


		/// <summary>
		///     MUST BE DECLARED. The local coordinates of the path the animation will follow.
		///     Default is null
		/// </summary>
		public Vector2[] PathVertices { get; set; }

		/// <summary>
		///     If set to false, running every segment takes the same time, the segments' length does not count. Otherwise, the
		///     speeed will be constant.
		///     Default is true
		/// </summary>
		public bool ConstantVelocity { get; set; } = true;

		/// <summary>
		///     Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space.
		///     Default is true
		/// </summary>
		public bool Relative { get; set; } = true;

		/// <summary>
		///     If set to true, the algorithm automaticallt generates one more segment between the first and last vertex.
		///     Default is false
		/// </summary>
		public bool Closed { get; set; } = false;

		/// <summary>
		///     TODO
		/// </summary>
		public SignalGen OverSpeedGen { get; set; } = Unity;

		/// <summary>
		///     TODO
		/// </summary>
		public SignalGen SegmentSpeedGen { get; set; } = Unity;


		public void Tick (float pc, GameObject gameObject)
		{
			pc = OverSpeedGen (pc);
			foreach (var currSegment in segments) {
				if (!(pc < currSegment.EndPercent)) continue;
				var currPercent = (pc - currSegment.StartPercent) / (currSegment.EndPercent - currSegment.StartPercent);
				currPercent = SegmentSpeedGen (currPercent);
				var pos = Vector2.Lerp (currSegment.StartPos, currSegment.EndPos, currPercent);
				if (Relative) {
					gameObject.Transform.MoveBy (pos - lastPos);
					lastPos = pos;
				} else {
					gameObject.Transform.MoveTo (pos);
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
			if (Closed) Close ();
			CalculateSegments ();
		}

		private void CalculateSegments ()
		{
			segments = new Segment[pathVertices.Count - 1];
			var totalLength = CalculateTotalLength (pathVertices);
			var accSegmentLength = 0.0f;

			for (var index = 0; index < segments.Length; index++) {
				var beginPos = pathVertices[index];
				var endPos = pathVertices[index + 1];

				var currentSegmentLength = ConstantVelocity
					? (beginPos - endPos).Length / totalLength
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
			if (pathVertices[0] != pathVertices[pathVertices.Count - 1]) pathVertices.Add (pathVertices[0]);
		}

		private static float CalculateTotalLength (RawList<Vector2> vertices)
		{
			var length = 0.0f;
			for (var index = 0; index < vertices.Count - 1; ++index) length += (vertices[index] - vertices[index + 1]).Length;
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