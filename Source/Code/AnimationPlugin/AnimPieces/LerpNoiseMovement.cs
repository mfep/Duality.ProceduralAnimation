using System;
using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class LerpNoiseMovement : IAnimPiece
	{
		public static Random staticRandom = new Random ((int)DateTime.Now.ToBinary ());

		private Vector2 lastPos;
		private float lastSamplePc;
		private float lastSamplePos;
		private float nextSamplePc;
		private float nextSamplePos;

		public Vector2 Direction { get; set; } = Vector2.UnitX;
		public float Frequency { get; set; } = 10.0f;
		public SignalGen FrequencyGen { get; set; } = Const1;
		public float Amplitude { get; set; } = 100.0f;
		public SignalGen AmplitudeGen { get; set; } = ExponentialDecr ();
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