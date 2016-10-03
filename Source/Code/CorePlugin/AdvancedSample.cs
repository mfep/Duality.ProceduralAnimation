using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class AdvancedSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddParallel (new IAnimPiece[]
					{
						new PathFollowMovement
						{
							Closed = true,
							SegmentSpeedGen = ExponentialGrow (3.0f),
							PathVertices =
								new[] { new Vector2 (-2500, 0), new Vector2 (0, -1500), new Vector2 (2500, 0), new Vector2 (0, 1500) }
						},
						new TrigonometricMovement2D { Amplitude = new Vector2 (10, 20), Frequency = new Vector2 (10, 20) },
						new Rotate { Frequency = 10.0f }
					},
					10.0f
				);
		}
	}
}