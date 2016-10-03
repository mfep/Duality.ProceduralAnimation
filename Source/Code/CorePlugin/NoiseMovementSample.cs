using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class NoiseMovementSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ().AddParallel (new IAnimPiece[]
				{
					new LerpNoiseMovement { Frequency = 10f, FrequencyGen = Linear(7f, 1f), AmplitudeGen = Const1, Direction = Vector2.UnitX, Amplitude = 500f},
					new LerpNoiseMovement { Frequency = 20f, Direction = Vector2.UnitY, Amplitude = 200f}
				}, 10.0f
			);
		}
	}
}