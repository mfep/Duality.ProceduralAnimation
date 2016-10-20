using System;
using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[RequiredComponent (typeof(AnimationPlayer))]
	[EditorHintCategory (ResNames.RealWorldExampleCategory)]
	public class StepCmp : Component
	{
		public enum StepDir
		{
			Left,
			Right,
			Up,
			Down
		}

		public ContentRef<AnimResource> StepLeftRes { get; set; }
		public ContentRef<AnimResource> StepRightRes { get; set; }
		public ContentRef<AnimResource> StepUpRes { get; set; }
		public ContentRef<AnimResource> StepDownRes { get; set; }

		public void Step (StepDir dir)
		{
			var player = GameObj.GetComponent<AnimationPlayer> ();
			if (player.IsPlaying)
				return;

			ContentRef<AnimResource> selectedAnimResource;
			switch (dir) {
				case StepDir.Left:
					selectedAnimResource = StepLeftRes;
					break;
				case StepDir.Right:
					selectedAnimResource = StepRightRes;
					break;
				case StepDir.Up:
					selectedAnimResource = StepUpRes;
					break;
				case StepDir.Down:
					selectedAnimResource = StepDownRes;
					break;
				default:
					throw new ArgumentOutOfRangeException (nameof (dir), dir, null);
			}

			player.Animation = selectedAnimResource;
			player.Stop ();
			player.Looping = false;
			player.Play ();
		}
	}
}