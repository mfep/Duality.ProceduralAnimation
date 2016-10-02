using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Use this AnimPiece to implement custom behaviour in the AnimResource.
	/// </summary>
	public class CallbackProvider : IAnimPiece
	{
		public delegate void CustomCallback (float pc, GameObject gameObject);

		/// <summary>
		///     This function is going to be called at every update, getting the current AnimPercent and the AnimationPlayer
		///     GameObject as argument.
		///     Default does nothing.
		/// </summary>
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