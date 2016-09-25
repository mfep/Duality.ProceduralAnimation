using Duality;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	public class PathFollowMovementSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()

				.AddSingleAnimPiece (
					new PathFollowMovement
					{
						PathVertices = new[] { new Vector2 (0, 0), new Vector2 (300, 0), new Vector2 (0, 300), new Vector2 (0, 0) },
						ConstantVelocity = true
					}, 2.0f)

				.AddSingleAnimPiece (
					new LinearMovement { StartPos = new Vector2 (0, 0), EndPos = new Vector2 (500, 500) }, 3.0f
				)

				.AddSingleAnimPiece (
					new PathFollowMovement
					{
						PathVertices = new[] { new Vector2 (500, 500), new Vector2 (500, 600), new Vector2 (1000, 2000) }
					}, 5.0f)

				.AddSingleAnimPiece (new Wait (), 3.0f)

				.AddSingleAnimPiece (
					new LinearMovement { StartPos = new Vector2 (1000, 2000), EndPos = new Vector2 (0,0)}, 2.0f
				);
		}
	}
}
