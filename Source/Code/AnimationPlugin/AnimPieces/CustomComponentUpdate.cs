using System;
using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class CustomComponentUpdate<TComponent> : IAnimPiece where TComponent : Component, ICmpAnimUpdatable
	{
		public void Initialize ()
		{			
		}

		public void Tick (float percent, GameObject gameObject)
		{
			var component = gameObject.GetComponent<TComponent> () as ICmpAnimUpdatable;
			component?.AnimTickCallback (percent);
		}
	}
}
