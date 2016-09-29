using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class PathFollowMovementSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddSingle (
					new PathFollowMovement
					{
						PathVertices = new[] { new Vector2 (0, 0), new Vector2 (300, 0), new Vector2 (0, 300), new Vector2 (0, 0) },
						ConstantVelocity = true
					}, 2.0f)
				.AddSingle (
					new SimpleMovement { StartPos = new Vector2 (0, 0), EndPos = new Vector2 (500, 500) }, 3.0f
				)
				.AddSingle (
					new PathFollowMovement
					{
						PathVertices = new[] { new Vector2 (500, 500), new Vector2 (500, 600), new Vector2 (1000, 2000) }
					}, 5.0f)
				.AddSingle (new Wait (), 3.0f)
				.AddSingle (
					new SimpleMovement { StartPos = new Vector2 (1000, 2000), EndPos = new Vector2 (0, 0) }, 2.0f
				);
		}
	}
}