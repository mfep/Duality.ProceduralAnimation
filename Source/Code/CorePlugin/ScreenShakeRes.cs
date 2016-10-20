using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory(ResNames.RealWorldExampleCategory)]
	public class ScreenShakeRes : AnimResource
	{
		public float NoiseAmplitude { get; set; } = 5.0f;
		public float NoiseFrequency { get; set; } = 15.0f;
		public float ShakeDuration { get; set; } = 0.2f;

		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.Add (new IAnimPiece[]
					{
						new LerpNoiseMovement { Amplitude = NoiseAmplitude, Frequency = NoiseFrequency, Direction = Vector2.UnitX },
						new LerpNoiseMovement { Amplitude = NoiseAmplitude, Frequency = NoiseFrequency, Direction = Vector2.UnitY }
					}, ShakeDuration
				);
		}
	}
}