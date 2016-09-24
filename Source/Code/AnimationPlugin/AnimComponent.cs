using System;
using Duality;

namespace ProceduralAnimation
{
	public class AnimationPlayer : Component, ICmpInitializable, ICmpUpdatable
	{
		public ContentRef<AnimResource> Animation { get; set; }
		public bool AutoPlay { get; set; }
		public bool Looping { get; set; }
		public float PlaybackRate { get; set; }

		public float PlaybackLength
		{
			get
			{
				if (Animation == null) return 0.0f;
				return Animation.Res?.OriginalLength * PlaybackRate ?? 0.0f;
			}
		}

		private bool isPlaying = false;
		private TimeSpan animStartTime;
		public bool IsPlaying
		{
			get
			{
				return isPlaying;
			}
			private set
			{
				if (Animation == null || Animation.Res == null) {
					isPlaying = false;
					return;
				}
				isPlaying = value;				
				animStartTime = Time.GameTimer;
			}
		}

		public AnimationPlayer ()
		{
			PlaybackRate = 1.0f;
		}

		public void OnInit (InitContext context)
		{
			if (AutoPlay && context == InitContext.Activate && DualityApp.ExecContext == DualityApp.ExecutionContext.Game) {
				IsPlaying = true;
			}
		}

		public void OnShutdown (ShutdownContext context)
		{
		}

		public void OnUpdate ()
		{
			if (IsPlaying) {
				Animate ();
			}
		}

		private void Animate ()
		{
			var currentTime = Time.GameTimer;
			var animPercent = (currentTime - animStartTime).TotalSeconds / PlaybackLength;
			if (animPercent >= 1.0) {
				if (Looping) {
					while (animPercent >= 1.0)
						animPercent -= 1.0;
				} else {
					IsPlaying = false;
					return;
				}				
			}
			if (Animation == null) {
				Log.Core.WriteError ("Animation is missing");
				return;
			}

			Animation.Res?.Tick ((float)animPercent, GameObj);
		}
	}
}
