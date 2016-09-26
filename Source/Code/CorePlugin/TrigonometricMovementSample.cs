using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
    [EditorHintCategory (ResNames.EditorCategory)]
    public class TrigonometricMovementSample : AnimResource
    {
        protected override AnimBuilder InitializePieces ()
        {
            return AnimBuilder.Start ()
                .AddSingle (
                    new TrigonometricMovement { Frequency = new Vector2 (1), Amplitude = new Vector2 (800) }, 4.0f
                );
        }
    }
}
