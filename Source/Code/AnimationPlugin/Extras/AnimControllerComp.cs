using Duality;
using Duality.Editor;
using Key = Duality.Input.Key;

namespace MFEP.Duality.Plugins.Animation.Extras
{
    [EditorHintCategory (ResNames.EditorCategory)]
    public class AnimControllerComp : Component, ICmpUpdatable
    {
        public Key StartKey { get; set; }
        public Key StopKey { get; set; }
        public Key PauseKey { get; set; }

        private AnimationPlayer AnimPlayer
        {
            get
            {
                return GameObj.GetComponent<AnimationPlayer> ();
            }
        }

        public void OnUpdate ()
        {
            if (DualityApp.Keyboard.KeyHit (StartKey)) {
                AnimPlayer?.Play ();
            }
            if (DualityApp.Keyboard.KeyHit (StopKey)) {
                AnimPlayer?.Stop ();
            }
            if (DualityApp.Keyboard.KeyHit (PauseKey)) {
                AnimPlayer?.Pause ();
            }
        }
    }
}
