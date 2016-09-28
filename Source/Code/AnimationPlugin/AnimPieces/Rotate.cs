using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class Rotate : IAnimPiece
	{
		public float Frequency { get; set; }

		public void Tick(float percent, GameObject gameObject)
		{
			gameObject.Transform?.TurnTo(percent * Frequency * MathF.TwoPi);
		}

		public void Initialize()
		{
		}
	}
}
