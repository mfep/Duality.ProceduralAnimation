using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

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
					new TrigonometricMovement { Frequency = new Vector2 (10), Amplitude = new Vector2 (20), Relative = true },
					new SimpleMovement { StartPos = Vector2.Zero, EndPos = new Vector2 (1400, 600), Relative = true }
				}, 5.0f);
		}
	}
}