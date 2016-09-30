using Duality;

namespace MFEP.Duality.Plugins.Animation
{
	public interface IAnimPiece
	{
		void Tick (float pc, GameObject gameObject);
		void Initialize ();
	}
}