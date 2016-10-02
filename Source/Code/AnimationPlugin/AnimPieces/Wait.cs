using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Does not do anything during the animation. Useful to introduce waiting times between two animation blocks.
	/// </summary>
	public class Wait : IAnimPiece
	{
		public void Initialize ()
		{
		}

		public void Tick (float pc, GameObject gameObject)
		{
		}
	}
}