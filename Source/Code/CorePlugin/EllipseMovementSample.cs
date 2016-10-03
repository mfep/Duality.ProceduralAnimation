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
				.AddSingle (
					new EllipseMovement { StartPhase = 270f, EndPhase = 270f - 360f, RadiusX = 600f}, 5.0f
				);
		}
	}
}