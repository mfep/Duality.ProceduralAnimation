﻿using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class LinearMovementSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddSingle (
					new SimpleMovement { StartPos = new Vector2 (0, 0), EndPos = new Vector2 (-300, -200) }, 2.0f)
				.AddSingle (
					new SimpleMovement { StartPos = new Vector2 (-300, -200), EndPos = new Vector2 (200, 300) }, 3.0f)
				.AddSingle (
					new SimpleMovement { StartPos = new Vector2 (200, 300), EndPos = new Vector2 (0, 0) }, 1.0f);
		}
	}
}