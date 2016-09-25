using System;
using Duality;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	public class CustomComponentUpdateSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddParalell ( new IAnimPiece[]
				{
					new SimpleMovement { EndPos = new Vector2 (500,0) },
					new CustomComponentUpdate<WritePercentComp> ()
				}, 5.0f);
		}
	}
}
