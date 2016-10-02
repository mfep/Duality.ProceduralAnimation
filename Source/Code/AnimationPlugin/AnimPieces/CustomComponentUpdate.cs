using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     This AnimPiece invokes the AnimTickCallback function on every Component which implements ICmpAnimUpdatable on the
	///     AnimationPlayer's GameObject.
	/// </summary>
	public class CustomComponentUpdate : IAnimPiece
	{
		public void Initialize ()
		{
		}

		public void Tick (float pc, GameObject gameObject)
		{
			var component = gameObject.GetComponents<ICmpAnimUpdatable> ();
			foreach (var cmp in component) cmp.AnimTickCallback (pc);
		}
	}
}