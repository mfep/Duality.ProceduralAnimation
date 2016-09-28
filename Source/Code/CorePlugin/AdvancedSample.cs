using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
    [EditorHintCategory(ResNames.EditorCategory)]
    public class AdvancedSample : AnimResource
    {
        protected override AnimBuilder InitializePieces()
        {
            return AnimBuilder.Start()
                .AddParalell( new IAnimPiece[]
                    {
                        new PathFollowMovement { Closed = true, Relative = true, Smoothing = true, ConstantVelocity = true,
                            PathVertices = new []{ new Vector2(-2500, 0), new Vector2(2500, 0), new Vector2(0, 1500) } },
                        new TrigonometricMovement { Amplitude = new Vector2(0, 200), Frequency = new Vector2(0, 20), Relative = true },
						new Rotate { Frequency = 10.0f }
                    },
                    10.0f
                );
        }
    }
}
