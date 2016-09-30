using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class Rotate : IAnimPiece
	{
		public float Frequency { get; set; }

		public void Tick (float pc, GameObject gameObject)
		{
			gameObject.Transform?.TurnTo (pc * Frequency * MathF.TwoPi);
		}

		public void Initialize ()
		{
		}
	}
}