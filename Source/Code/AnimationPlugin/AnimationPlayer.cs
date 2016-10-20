using System;
using Duality;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation
{
	/// <summary>
	///     Loads and plays AnimResources on the GameObject. Manages the animation's state, and provides interface to control
	///     it (Play, Pause, Stop).
	/// </summary>
	[EditorHintCategory (ResNames.EditorCategory)]
	[EditorHintImage (ResNames.AnimComponentImagePath)]
	public class AnimationPlayer : Component, ICmpInitializable, ICmpUpdatable
	{
		private float accAnimPercent;
		private ContentRef<AnimResource> animation;
		private TimeSpan animStartTime;
		private State state = State.Stopped;

		/// <summary>
		///     The current animation progress. Between 0 and 1. Readonly for now.
		/// </summary>
		[EditorHintFlags (MemberFlags.ReadOnly)]
		[EditorHintDecimalPlaces(3)]
		public float Percent { get; private set; }

		/// <summary>
		///     The AnimResource that is played.
		///     Default is null
		/// </summary>
		public ContentRef<AnimResource> Animation
		{
			get { return animation; }
			set { animation = value; InitializeResource(); }
		}

		/// <summary>
		///     Wheter the animation starts at staring the game/sandbox.
		///     Default is false
		/// </summary>
		public bool AutoPlay { get; set; }

		/// <summary>
		///     Wheter the animation starts from the beginning when reached its end.
		///     Default is false
		/// </summary>
		public bool Looping { get; set; }

		/// <summary>
		///     The relative speed the animation is playing back.
		///     Default is 1f
		/// </summary>
		public float PlaybackRate { get; set; } = 1f;

		/// <summary>
		///     The original length of the AnimResource multiplied by PlaybackRate
		/// </summary>
		public float PlaybackLength
		{
			get
			{
				if (Animation == null) return 0.0f;
				return Animation.Res?.OriginalLength / PlaybackRate ?? 0.0f;
			}
		}

		/// <summary>
		///     Wheter the animation is currently playing or is stopped. Settable.
		/// </summary>
		public bool IsPlaying
		{
			get { return state == State.Playing; }
			private set
			{
				if (value) Play ();
				else Pause ();
			}
		}

		public void OnInit (InitContext context)
		{
			if (AutoPlay && (context == InitContext.Activate) && (DualityApp.ExecContext == DualityApp.ExecutionContext.Game)) {
				Play ();
				accAnimPercent = 0.0f;
			}
		}

		public void OnShutdown (ShutdownContext context)
		{
		}

		public void OnUpdate ()
		{
			if (IsPlaying) Animate ();
		}

		public void Play ()
		{
			if (state == State.Stopped)
				InitializeResource ();
			if ((Animation == null) || (Animation.Res == null)) return;
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
			InitializeResource();
			accAnimPercent = 0.0f;
			state = State.Stopped;
			Animation.Res.Tick (0, GameObj);
		}

		private float GetAnimPercent ()
		{
			var currentTime = Time.GameTimer;
			return accAnimPercent + (float)(currentTime - animStartTime).TotalSeconds / PlaybackLength;
		}

		private void Animate ()
		{
			Percent = GetAnimPercent ();
			if (Percent >= 1.0) {
				if (Looping) {
					while (Percent >= 1.0f)
						Percent -= 1.0f;
				} else {
					IsPlaying = false;
					Percent = 1.0f;
				}
			}
			if (Animation == null) {
				Log.Core.WriteError ("Animation is missing");
				return;
			}

			Animation.Res?.Tick (Percent, GameObj);
		}

		private void InitializeResource ()
		{
			Animation.Res.Initialize ();
		}

		private enum State
		{
			Playing,
			Stopped,
			Paused
		}
	}
}