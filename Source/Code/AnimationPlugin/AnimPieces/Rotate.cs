using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Simple rotating AnimPiece.
	/// </summary>
	public class Rotate : IAnimPiece
	{
		private float lastTurn;

		/// <summary>
		///     The rotation frequency. 1f means one rotation over the animation.
		///     Default is 1f
		/// </summary>
		public float Frequency { get; set; } = 1f;

		/// <summary>
		///     The mapping of the angular movement.
		///     Default value is Unity
		/// </summary>
		public SignalGen FrequencyGen { get; set; } = Const1;

		/// <summary>
		///     Wheter this Piece's effect overrides all other rotation.
		///     Default is true
		/// </summary>
		public bool Relative { get; set; } = true;

		public void Tick (float pc, GameObject gameObject)
		{
			var newTurn = pc * FrequencyGen (pc) * Frequency * MathF.TwoPi;
			if (Relative) {
				gameObject.Transform.TurnBy (newTurn - lastTurn);
				lastTurn = newTurn;
			} else {
				gameObject.Transform.TurnTo (newTurn);
			}
		}

		public void Initialize ()
		{
		}
	}
}