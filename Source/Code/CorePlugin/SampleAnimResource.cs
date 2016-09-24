using System;
using Duality;
using ProceduralAnimation.AnimPieces;

namespace ProceduralAnimation.Sample
{
	public class AnimResourceSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
			.AddSingleAnimPiece (
				new LinearMovement { StartPos = new Vector2 (0, 0), EndPos = new Vector2 (-300, -200) }, 2.0f)
			.AddSingleAnimPiece (
				new LinearMovement { StartPos = new Vector2 (-300, -200), EndPos = new Vector2 (200, 300) }, 3.0f)
			.AddSingleAnimPiece (
				new LinearMovement { StartPos = new Vector2 (200, 300), EndPos = new Vector2 (0, 0) }, 1.0f);
		}
	}
}
