using System.Collections.Generic;
using Duality;
using Duality.Drawing;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation.Extras
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class PathVisualizer : Component, ICmpRenderer, ICmpUpdatable
	{
		private readonly CanvasBuffer buffer = new CanvasBuffer ();

		private readonly List<Vector2> pointsFollowed = new List<Vector2> ();

		public PathVisualizer ()
		{
			BoundRadius = 500.0f;
		}

		public ColorRgba Color { get; set; }
		public int FollowedFrames { get; set; }

		public bool IsVisible (IDrawDevice device)
		{
			if ((device.VisibilityMask & VisibilityFlag.ScreenOverlay) == VisibilityFlag.None) return true;
			//if ((device.VisibilityMask & VisibilityFlag.AllGroups) == VisibilityFlag.None) return false;
			return false;
		}

		public void Draw (IDrawDevice device)
		{
			var canvas = new Canvas (device, buffer);
			canvas.State.ColorTint = Color;

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