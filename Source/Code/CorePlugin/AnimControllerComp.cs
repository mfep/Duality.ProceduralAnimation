using Duality;
using Duality.Editor;
using Key = Duality.Input.Key;

namespace MFEP.Duality.Plugins.Animation.Sample
{
    [EditorHintCategory (ResNames.EditorCategory)]
    public class AnimControllerComp : Component, ICmpUpdatable
    {
        private AnimationPlayer AnimPlayer
        {
            get
            {
                return GameObj.GetComponent<AnimationPlayer> ();
            }
        }

        public void OnUpdate ()
        {
            if (DualityApp.Keyboard.KeyHit (Key.P)) {
                AnimPlayer?.Play ();
            }
            if (DualityApp.Keyboard.KeyHit (Key.S)) {
                AnimPlayer?.Stop ();
            }
            if (DualityApp.Keyboard.KeyHit (Key.A)) {
                AnimPlayer?.Pause ();
            }
        }
    }
}
