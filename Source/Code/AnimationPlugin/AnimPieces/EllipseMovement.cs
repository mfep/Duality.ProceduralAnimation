using Duality;
using static Duality.MathF;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Moves the gameObject on an elliptical arc. This path can be a circle/ellipse/circular arc depending on the
	///     parameters.
	/// </summary>
	public class EllipseMovement : IAnimPiece
	{
		private Vector2 lastPos;

		/// <summary>
		///     The size of the path ellipse on the X axis.
		///     Default is 200f
		/// </summary>
		public float RadiusX { get; set; } = 200f;

		/// <summary>
		///     RadiusX's multiplier function.
		///     Default is Const1
		/// </summary>
		public SignalGen RadiusXGen { get; set; } = Const1;

		/// <summary>
		///     The size of the path ellipse on the Y axis.
		///     Default is 200f
		/// </summary>
		public float RadiusY { get; set; } = 200f;

		/// <summary>
		///     RadiusY's multiplier function.
		///     Default is Const1
		/// </summary>
		public SignalGen RadiusYGen { get; set; } = Const1;

		/// <summary>
		///     The starting phase angle on the path in radians. Determines the starting point on the arc. 0 means the most right
		///     point, Pi/2 is the bottom one, and so along.
		///     Default is 0f
		/// </summary>
		public float StartPhase { get; set; } = 0f;

		/// <summary>
		///     The ending phase angle on the path in radians.
		///     Default is 0f
		/// </summary>
		public float EndPhase { get; set; } = TwoPi;

		/// <summary>
		///     Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space.
		///     Default is true
		/// </summary>
		public bool Relative { get; set; } = true;

		public void Tick (float pc, GameObject gameObject)
		{
			var currentPhase = Lerp (StartPhase, EndPhase, pc);
			var newPos = new Vector2 (RadiusXGen (pc) * RadiusX * Cos (currentPhase),
				RadiusYGen (pc) * RadiusY * Sin (currentPhase));
			if (Relative) {
				gameObject.Transform.MoveBy (newPos - lastPos);
				lastPos = newPos;
			} else {
				gameObject.Transform.MoveTo (newPos);
			}
		}

		public void Initialize ()
		{
		}
	}
}