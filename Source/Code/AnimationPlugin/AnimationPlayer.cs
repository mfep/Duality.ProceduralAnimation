using System;
using Duality;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation
{
    [EditorHintCategory (ResNames.EditorCategory)]
    [EditorHintImage (ResNames.AnimComponentImagePath)]
	public class AnimationPlayer : Component, ICmpInitializable, ICmpUpdatable
	{
		private enum State
		{
			Playing, Stopped, Paused
		}

		public ContentRef<AnimResource> Animation { get; set; }
		public bool AutoPlay { get; set; }
		public bool Looping { get; set; }
		public float PlaybackRate { get; set; }

		public float PlaybackLength
		{
			get
			{
				if (Animation == null) return 0.0f;
				return Animation.Res?.OriginalLength / PlaybackRate ?? 0.0f;
			}
		}

		public bool IsPlaying
		{
			get
			{
				return state == State.Playing;
			}
			private set
			{
                if (value) {
                    Play ();
                } else {
                    Pause ();
                }
			}
		}

        private TimeSpan animStartTime;
        private State state = State.Stopped;
        private float accAnimPercent;		

		public AnimationPlayer ()
		{
			PlaybackRate = 1.0f;
		}

		public void OnInit (InitContext context)
		{
			if (AutoPlay && context == InitContext.Activate && DualityApp.ExecContext == DualityApp.ExecutionContext.Game) {
                Play ();
				accAnimPercent = 0.0f;
			}
		}

		public void OnShutdown (ShutdownContext context)
		{
		}

        public void Play ()
        {
	        if (state == State.Stopped)
	        {
		        InitializeResource ();
	        }
            if (Animation == null || Animation.Res == null) {                
                return;
            }
            animStartTime = Time.GameTimer;
            state = State.Playing;	    
        }

        public void Pause ()
        {
            accAnimPercent = GetAnimPercent ();
            state = State.Paused;
        }

        public void Stop ()
        {
            accAnimPercent = 0.0f;
            state = State.Stopped;
            Animation.Res.Tick (0, GameObj);
        }

		public void OnUpdate ()
		{
			if (IsPlaying) {
				Animate ();                
			}
		}

        private float GetAnimPercent ()
        {
            var currentTime = Time.GameTimer;
            return accAnimPercent + (float)((currentTime - animStartTime).TotalSeconds) / PlaybackLength;
        }

		private void Animate ()
		{
            var animPercent = GetAnimPercent ();
			if (animPercent >= 1.0) {
				if (Looping) {
					while (animPercent >= 1.0f)
						animPercent -= 1.0f;
				} else {
					IsPlaying = false;
					return;
				}				
			}
			if (Animation == null) {
				Log.Core.WriteError ("Animation is missing");
				return;
			}

			Animation.Res?.Tick (animPercent, GameObj);
		}

		private void InitializeResource ()
		{
			Animation.Res.Initialize ();
		}
	}
}
