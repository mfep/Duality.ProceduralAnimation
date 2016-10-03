using Duality;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation
{
	/// <summary>
	///     Inherit from this class when creating custom AnimResources. Have to implement the InitializePieces method.
	/// </summary>
	[EditorHintImage (ResNames.AnimResourceImagePath)]
	public abstract class AnimResource : Resource
	{
		[DontSerialize] private AnimBuilder builder;

		public float OriginalLength => builder?.OverallTime ?? 0.0f;

		protected abstract AnimBuilder InitializePieces ();

		public void Initialize ()
		{
			builder = InitializePieces ();
			if (builder == null) Log.Core.WriteError ("InitializePieces should not return null!");
		}

		internal void Tick (float percent, GameObject gameObject)
		{
			builder.Tick (percent, gameObject);
		}
	}
}