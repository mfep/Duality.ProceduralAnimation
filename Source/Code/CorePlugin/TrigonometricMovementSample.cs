﻿using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class TrigonometricMovementSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddParalell (new IAnimPiece[]
				{
					new TrigonometricMovement
					{
						Amplitude = new Vector2 (1000),
						FreqGenX = Linear (5),
						FreqGenY = Linear (5),
						AmpGenX = AbsSin,
						AmpGenY = AbsSin,
						PhaseGenX = SimpleCos,
						PhaseGenY = SimpleCos
					}
				}, 5.0f);
		}
	}
}