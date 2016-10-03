using System;
using System.Collections.Generic;
using System.Linq;
using Duality;

namespace MFEP.Duality.Plugins.Animation
{
	/// <summary>
	///     Use this class to build the animation in your AnimResources. Supports fluent syntax.
	/// </summary>
	public sealed class AnimBuilder
	{
		private readonly List<AnimPieceWrapper> pieceList;

		private AnimBuilder ()
		{
			pieceList = new List<AnimPieceWrapper> ();
		}

		internal float OverallTime { get; private set; }

		/// <summary>
		///     Starting point of the animation chain.
		/// </summary>
		/// <returns></returns>
		public static AnimBuilder Start ()
		{
			return new AnimBuilder ();
		}

		/// <summary>
		///     Adds a single AnimPiece to the animation chain.
		/// </summary>
		/// <param name="piece">The IAnimPiece to add.</param>
		/// <param name="time">The time (seconds) this AnimPiece takes to finish.</param>
		/// <returns></returns>
		public AnimBuilder AddSingle (IAnimPiece piece, float time)
		{
			CheckTime (time);
			piece.Initialize ();
			pieceList.Add (new AnimPieceWrapper { Pieces = new[] { piece }, Time = time });
			OverallTime += time;
			return this;
		}

		/// <summary>
		///     Adds an array of AnimPieces that will play simultaneously.
		/// </summary>
		/// <param name="pieces"></param>
		/// <param name="time">Time (seconds) these pieces will take to finish.</param>
		/// <returns></returns>
		public AnimBuilder AddParalell (IAnimPiece[] pieces, float time)
		{
			CheckTime (time);
			foreach (var piece in pieces) piece.Initialize ();
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
			foreach (var piece in piecesAtTick) piece.Tick (pieceOwnPercent, gameObject);
		}

		private IAnimPiece[] GetPieceAtPercent (float percent, out float pieceOwnPercent)
		{
			var accTime = 0.0f;
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
			if (time <= 0) throw new ArgumentOutOfRangeException (nameof (time));
		}

		private class AnimPieceWrapper
		{
			public IAnimPiece[] Pieces { get; set; }
			public float Time { get; set; }
		}
	}
}