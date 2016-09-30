using Duality;
using Duality.Components.Renderers;
using Duality.Drawing;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	public class SimpleColor : IAnimPiece
	{
		public ColorRgba StartColor { get; set; }
		public ColorRgba EndColor { get; set; }
		public SignalGen ColorGen { get; set; } = Unity;

		public void Initialize ()
		{
		}

		public void Tick (float pc, GameObject gameObject)
		{
			var newColor = ColorRgba.Lerp (StartColor, EndColor, ColorGen (pc));

			var renderer = gameObject.GetComponent<SpriteRenderer> ();
			if (renderer == null) {
				var animRenderer = gameObject.GetComponent<AnimSpriteRenderer> ();
				if (animRenderer == null) {
					Log.Core.WriteError ($"Neither a SpriteRenderer nor an AnimSpriteRenderer is attached to {gameObject}");
					return;
				}
				animRenderer.ColorTint = newColor;
			} else {
				renderer.ColorTint = newColor;
			}
		}
	}
}