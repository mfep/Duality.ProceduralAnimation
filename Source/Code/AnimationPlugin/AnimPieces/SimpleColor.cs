using Duality;
using Duality.Drawing;
using Duality.Components.Renderers;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class SimpleColor : IAnimPiece
	{
		public ColorRgba StartColor { get; set; }
		public ColorRgba EndColor { get; set; }
		public bool Smoothing { get; set; }

		public void Initialize ()
		{			
		}

		public void Tick (float percent, GameObject gameObject)
		{
			ColorRgba newColor = ColorRgba.Lerp (StartColor, EndColor, Smoothing ? Utilities.Smoothstep (percent) : percent);

			var renderer = gameObject.GetComponent<SpriteRenderer> ();
			if (renderer == null) {
				var animRenderer = gameObject.GetComponent<AnimSpriteRenderer> ();
				if (animRenderer == null) {
					Log.Core.WriteError ($"Neither a SpriteRenderer nor an AnimSpriteRenderer is attached to {gameObject.ToString ()}");
					return;
				}
				animRenderer.ColorTint = newColor;
			} else {
				renderer.ColorTint = newColor;
			}
		}
	}
}
