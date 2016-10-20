using Duality;
using Duality.Editor;
using Duality.Input;
using MFEP.Duality.Plugins.Animation.Sample.Properties;
using static MFEP.Duality.Plugins.Animation.Sample.StepCmp;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[RequiredComponent (typeof(StepCmp))]
	[EditorHintCategory (ResNames.RealWorldExampleCategory)]
	public class ExampleController : Component, ICmpUpdatable
	{
		public AnimationPlayer ScreenShakeAnimationPlayer { get; set; }
		private StepCmp StepComponent => GameObj.GetComponent<StepCmp> ();

		public void OnUpdate ()
		{
			if (DualityApp.Keyboard.KeyHit (Key.Left))
				StepComponent.Step (StepDir.Left);
			else if (DualityApp.Keyboard.KeyHit (Key.Right))
				StepComponent.Step (StepDir.Right);
			else if (DualityApp.Keyboard.KeyHit (Key.Up))
				StepComponent.Step (StepDir.Up);
			else if (DualityApp.Keyboard.KeyHit (Key.Down))
				StepComponent.Step (StepDir.Down);

			if (DualityApp.Keyboard.KeyHit (Key.Space)) {
				ScreenShakeAnimationPlayer.Stop ();
				ScreenShakeAnimationPlayer.Play ();
			}
		}
	}
}