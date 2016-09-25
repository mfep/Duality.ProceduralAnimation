using System;
using System.Collections.Generic;
using Duality;

namespace MFEP.Duality.Plugins.Animation
{
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
		private AnimBuilder builder = null;

		public AnimResource ()
		{
			builder = InitializePieces ();
			if (builder == null) {
				Log.Core.WriteError ("InitializePieces should not return null!");
				return;
			}
		}

		internal void Tick (float percent, GameObject gameObject)
		{
			builder.Tick (percent, gameObject);
		}
	}
}
