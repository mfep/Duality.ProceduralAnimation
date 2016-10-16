using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class EllipseMovementSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.Add (
					new EllipseMovement { StartPhase = 0f, EndPhase = MathF.PiOver2, RadiusX = 600f}, 1.0f
				);
		}
	}
}