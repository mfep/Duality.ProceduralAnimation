using Duality;

namespace MFEP.Duality.Plugins.Animation
{
	/// <summary>
	///     Building block of the animations.
	///     Initialize runs at the start of the animation.
	///     Tick runs at every update.
	/// </summary>
	public interface IAnimPiece
	{
		void Tick (float pc, GameObject gameObject);
		void Initialize ();
	}
}