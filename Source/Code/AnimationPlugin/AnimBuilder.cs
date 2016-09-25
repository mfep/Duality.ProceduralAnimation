using System;
using Duality;
using System.Collections.Generic;
using System.Linq;

namespace MFEP.Duality.Plugins.Animation
{
	public sealed class AnimBuilder
	{
		internal float OverallTime { get; private set; }

		private List<AnimPieceWrapper> pieceList;

		private AnimBuilder ()
		{
			pieceList = new List<AnimPieceWrapper> ();
		}

		public static AnimBuilder Start ()
		{
			return new AnimBuilder ();
		}

		public AnimBuilder AddSingleAnimPiece (IAnimPiece piece, float time)
		{
			CheckTime (time);
			pieceList.Add (new AnimPieceWrapper { Pieces = new IAnimPiece[] { piece }, Time = time });
			OverallTime += time;
			return this;
		}

		public AnimBuilder AddParalellAnimPieces (IAnimPiece[] pieces, float time)
		{
			CheckTime (time);
			pieceList.Add (new AnimPieceWrapper { Pieces = pieces, Time = time });
			OverallTime += time;
			return this;
		}

		internal void Tick (float percent, GameObject gameObject)
		{
			float pieceOwnPercent;
			var piecesAtTick = GetPieceAtPercent (percent, out pieceOwnPercent);
			if (piecesAtTick == null) {
				Log.Core.WriteError ("No pieces at this tick!");
				return;
			}
			foreach (var piece in piecesAtTick) {
				piece.Tick (pieceOwnPercent, gameObject);
			}
		}		

		private IAnimPiece[] GetPieceAtPercent (float percent, out float pieceOwnPercent)
		{
			float accTime = 0.0f;
			var relativeTimes = pieceList.Select (wrapper =>
			{
				var perc = accTime / OverallTime;
				accTime += wrapper.Time;
				return new { StartPercent = perc, Wrapper = wrapper };
			});
			
			foreach (var iter in relativeTimes) {
				pieceOwnPercent = (percent - iter.StartPercent) * OverallTime / iter.Wrapper.Time;
				if (pieceOwnPercent > 1.0f)
					continue;
				return iter.Wrapper.Pieces;
			}
			pieceOwnPercent = 0.0f;
			return null;
		}

		private void CheckTime (float time)
		{
			if (time <= 0.0f)
				throw new ArgumentOutOfRangeException ();
		}		

		private class AnimPieceWrapper
		{
			public IAnimPiece[] Pieces { get; set; }
			public float Time { get; set; }
		}
	}
}
