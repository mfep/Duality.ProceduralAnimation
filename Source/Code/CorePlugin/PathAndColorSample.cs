using Duality;
using Duality.Drawing;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	public class PathAndColorSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddParalell (new IAnimPiece[]
				{
					new PathFollowMovement
					{
						PathVertices = new [] { new Vector2 (0,0), new Vector2 (250,316), new Vector2 (316,512), new Vector2 (0,0) }
					},
					new LinearColor { StartColor = ColorRgba.White, EndColor = ColorRgba.Blue }
				}, 1.0f);
		}
	}
}
