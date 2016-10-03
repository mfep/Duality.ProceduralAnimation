using System;
using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Implements random movement based on a simple noise algorithm. The Direction attribute controls the direction of the
	///     movement.
	/// </summary>
	public class LerpNoiseMovement : IAnimPiece
	{
		private static readonly Random staticRandom = new Random ((int)DateTime.Now.ToBinary ());

		private Vector2 lastPos;
		private float lastSamplePc;
		private float lastSamplePos;
		private float nextSamplePc;
		private float nextSamplePos;


		/// <summary>
		///     Controls the direction of the random movement. Its length is indifferent, will be normalized.
		///     Default is Vector2.UnitX
		/// </summary>
		public Vector2 Direction { get; set; } = Vector2.UnitX;

		/// <summary>
		///     The frequency of the direction changes.
		///     Default is 10f
		/// </summary>
		public float Frequency { get; set; } = 10f;

		/// <summary>
		///     real_frequency := Frequency * FreqencyGen (currentAnimPercent)
		///     Default is Const1
		/// </summary>
		public SignalGen FrequencyGen { get; set; } = Const1;

		/// <summary>
		///     The noise amplitude, the strength of this effect.
		///     Default is 100f
		/// </summary>
		public float Amplitude { get; set; } = 100f;

		/// <summary>
		///     real_Amplitude := Amplitude * AmplitudeGen (currentAnimPercent)
		///     Default is ExponentialDecr
		/// </summary>
		public SignalGen AmplitudeGen { get; set; } = ExponentialDecr ();

		/// <summary>
		///     Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space.
		///     Default is true
		/// </summary>
		public bool Relative { get; set; } = true;


		public void Tick (float pc, GameObject gameObject)
		{
			if (pc >= nextSamplePc) CalculateSample (pc);
			var newPos = Direction *
						MathF.Lerp (lastSamplePos, nextSamplePos, (pc - lastSamplePc) / (nextSamplePc - lastSamplePc));
			if (Relative) {
				gameObject.Transform.MoveBy (newPos - lastPos);
				lastPos = newPos;
			} else {
				gameObject.Transform.MoveTo (newPos);
			}
		}

		public void Initialize ()
		{
			Direction.Normalize ();
		}

		private void CalculateSample (float pc)
		{
			var tmp = nextSamplePc;
			lastSamplePc = nextSamplePc;
			nextSamplePc = tmp + 1.0f / Frequency / FrequencyGen (pc);

			lastSamplePos = nextSamplePos;
			nextSamplePos = staticRandom.NextFloat (-1.0f, 1.0f) * Amplitude * AmplitudeGen (pc);
		}
	}
}