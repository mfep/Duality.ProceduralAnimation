using Duality;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation
{
    [EditorHintImage (ResNames.AnimResourceImagePath)]
    public abstract class AnimResource : Resource
	{
		protected abstract AnimBuilder InitializePieces ();

		public float OriginalLength
		{
			get
			{
				return builder?.OverallTime ?? 0.0f;
			}
		}

		[DontSerialize]
		private AnimBuilder builder;

		public void Initialize ()
		{
			builder = InitializePieces ();
			if (builder == null) {
				Log.Core.WriteError ("InitializePieces should not return null!");
			}
		}

		internal void Tick (float percent, GameObject gameObject)
		{
			builder.Tick (percent, gameObject);
		}
	}
}
