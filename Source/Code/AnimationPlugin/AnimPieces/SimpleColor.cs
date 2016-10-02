using Duality;
using Duality.Components.Renderers;
using Duality.Drawing;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Simple color interpolating AnimPiece.
	/// </summary>
	public class SimpleColor : IAnimPiece
	{
		/// <summary>
		///     Color at animation start.
		///     Default is ColorRgba.Black
		/// </summary>
		public ColorRgba StartColor { get; set; } = ColorRgba.Black;

		/// <summary>
		///     Color at animation end.
		///     Default is ColorRgba.White
		/// </summary>
		public ColorRgba EndColor { get; set; } = ColorRgba.White;

		/// <summary>
		///     Color interpolating function.
		///     Default is Unity
		/// </summary>
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