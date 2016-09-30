using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class CallbackProvider : IAnimPiece
	{
		public delegate void CustomCallback (float pc, GameObject gameObject);

		public CustomCallback Callback { get; set; } = (_, __) => { };

		public void Tick (float pc, GameObject gameObject)
		{
			Callback (pc, gameObject);
		}

		public void Initialize ()
		{
		}
	}
}