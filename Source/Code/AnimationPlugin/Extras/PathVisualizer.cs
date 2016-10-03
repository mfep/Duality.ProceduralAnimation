using System.Collections.Generic;
using Duality;
using Duality.Drawing;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation.Extras
{
	/// <summary>
	///     Draws a line that connects the GameObject's positions in the last n frame.
	///     Beware! Not very effective.
	/// </summary>
	[EditorHintCategory (ResNames.EditorCategory)]
	public class PathVisualizer : Component, ICmpRenderer, ICmpUpdatable
	{
		private readonly CanvasBuffer buffer = new CanvasBuffer ();

		private readonly List<Vector2> pointsFollowed = new List<Vector2> ();

		/// <summary>
		///     Color of the line drawn.
		/// </summary>
		public ColorRgba Color { get; set; } = ColorRgba.White;

		/// <summary>
		///     How many frames' positions should connect. Don't set this too high.
		/// </summary>
		public int FollowedFrames { get; set; } = 100;

		public bool IsVisible (IDrawDevice device)
		{
			return (device.VisibilityMask & VisibilityFlag.ScreenOverlay) == VisibilityFlag.None;
			//if ((device.VisibilityMask & VisibilityFlag.AllGroups) == VisibilityFlag.None) return false;
		}

		public void Draw (IDrawDevice device)
		{
			var canvas = new Canvas (device, buffer) { State = { ColorTint = Color } };

			var lastVect = Vector2.Zero;
			if (pointsFollowed.Count != 0)
				lastVect = pointsFollowed[0];

			foreach (var pos in pointsFollowed) {
				canvas.DrawLine (lastVect.X, lastVect.Y, pos.X, pos.Y);
				lastVect = pos;
			}
		}

		public float BoundRadius { get; }

		public void OnUpdate ()
		{
			if (pointsFollowed.Count >= FollowedFrames)
				pointsFollowed.RemoveAt (0);
			pointsFollowed.Add (GameObj.Transform.Pos.Xy);
		}
	}
}