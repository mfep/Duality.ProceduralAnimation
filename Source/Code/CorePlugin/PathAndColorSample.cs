using Duality;
using Duality.Editor;
using Duality.Drawing;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
    [EditorHintCategory (ResNames.EditorCategory)]
    public class PathAndColorSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
            return AnimBuilder.Start ()
                .AddParalell (new IAnimPiece[]
                {
                    new PathFollowMovement
                    {
                        PathVertices = new [] { new Vector2 (0,0), new Vector2 (250,316), new Vector2 (316,512) },
                        Closed = true
                    },
                    new SimpleColor { StartColor = ColorRgba.White, EndColor = ColorRgba.Blue }
                }, 1.0f)
            .AddParalell (new IAnimPiece[]
            {
                new SimpleColor { StartColor = ColorRgba.Blue, EndColor = ColorRgba.White, Smoothing = true },
                new SimpleMovement { StartPos = new Vector2 (0,0), EndPos = new Vector2 (1000, 0), Smoothing = true }
            }, 2.0f);
        }
    }
}
