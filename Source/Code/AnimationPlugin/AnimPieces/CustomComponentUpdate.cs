using System;
using Duality;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class CustomComponentUpdate<TComponent> : IAnimPiece where TComponent : Component, ICmpAnimUpdateable
	{
		public void Initialize ()
		{			
		}

		public void Tick (float percent, GameObject gameObject)
		{
			var component = gameObject.GetComponent<TComponent> () as ICmpAnimUpdateable;
			component?.AnimTickCallback (percent);
		}
	}
}
