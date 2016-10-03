using Duality;
using Duality.Editor;
using Duality.Input;

namespace MFEP.Duality.Plugins.Animation.Extras
{
	/// <summary>
	///     Can control the animation state of the attached GameObject's AnimationPlayer.
	/// </summary>
	[EditorHintCategory (ResNames.EditorCategory)]
	[RequiredComponent (typeof(AnimationPlayer))]
	public class AnimControllerComp : Component, ICmpUpdatable
	{
		public Key StartKey { get; set; }
		public Key StopKey { get; set; }
		public Key PauseKey { get; set; }

		private AnimationPlayer AnimPlayer => GameObj.GetComponent<AnimationPlayer> ();

		public void OnUpdate ()
		{
			if (DualityApp.Keyboard.KeyHit (StartKey)) AnimPlayer.Play ();
			if (DualityApp.Keyboard.KeyHit (StopKey)) AnimPlayer.Stop ();
			if (DualityApp.Keyboard.KeyHit (PauseKey)) AnimPlayer.Pause ();
		}
	}
}