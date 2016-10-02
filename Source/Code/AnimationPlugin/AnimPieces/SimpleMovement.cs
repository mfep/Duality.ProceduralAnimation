using Duality;
using static MFEP.Duality.Plugins.Animation.Utils;

namespace MFEP.Duality.Plugins.Animation.AnimPieces
{
	/// <summary>
	///     Move the GameObject on the line between StartPos and EndPos.
	/// </summary>
	public class SimpleMovement : IAnimPiece
	{
		/// <summary>
		///     Starting position of the animation. Local space.
		///     Default is Vector2.Zero
		/// </summary>
		public Vector2 StartPos { get; set; } = Vector2.Zero;

		/// <summary>
		///     Final position of the animation. Local space.
		///     Default is Vector2.Zero
		/// </summary>
		public Vector2 EndPos { get; set; } = Vector2.Zero;

		/// <summary>
		///     Position interpolation function.
		///     Default is Unity
		/// </summary>
		public SignalGen PosGen { get; set; } = Unity;

		/// <summary>
		///     Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space.
		///     Default is true
		/// </summary>
		public bool Relative { get; set; } = true;

		private Vector2 lastPos { get; set; }

		public void Tick (float pc, GameObject gameObject)
		{
			var pos = Vector2.Lerp (StartPos, EndPos, PosGen (pc));
			if (Relative) {
				gameObject.Transform?.MoveBy (pos - lastPos);
				lastPos = pos;
			} else {
				gameObject.Transform?.MoveTo (pos);
			}
		}

		public void Initialize ()
		{
		}
	}
}