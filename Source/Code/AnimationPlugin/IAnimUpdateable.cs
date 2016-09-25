using System;
using Duality;

namespace MFEP.Duality.Plugins.Animation
{
	public interface ICmpAnimUpdateable
	{
		void AnimTickCallback (float currentPercent);
	}
}
