using Duality;
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
						FreqGen = Linear (5),
						AmpGen = AbsSin,
						PhaseGen = SimpleCos
					}
				}, 5.0f);
		}
	}
}