using System.Collections.Generic;
using Duality;
using Duality.Drawing;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation.Extras
{
    [EditorHintCategory(ResNames.EditorCategory)]
    public class PathVisualizer : Component, ICmpRenderer, ICmpUpdatable
    {
        public ColorRgba Color { get; set; }
        public int FollowedFrames { get; set; }

        private readonly List<Vector2> pointsFollowed = new List<Vector2>();
        private readonly CanvasBuffer buffer = new CanvasBuffer();

        public PathVisualizer()
        {
            BoundRadius = 500.0f;
        }

        public bool IsVisible(IDrawDevice device)
        {
            if ((device.VisibilityMask & VisibilityFlag.ScreenOverlay) == VisibilityFlag.None) return true;
            //if ((device.VisibilityMask & VisibilityFlag.AllGroups) == VisibilityFlag.None) return false;
            return false;
        }

        public void Draw(IDrawDevice device)
        {
            Canvas canvas = new Canvas(device, buffer);
            canvas.State.ColorTint = Color;

            Vector2 lastVect = Vector2.Zero;
            if (pointsFollowed.Count != 0)
                lastVect = pointsFollowed[0];

            foreach (var pos in pointsFollowed)
            {
                canvas.DrawLine(lastVect.X, lastVect.Y, pos.X, pos.Y);
                lastVect = pos;
            }
        }

        public float BoundRadius { get; }


        public void OnUpdate()
        {
            if (pointsFollowed.Count >= FollowedFrames)
            {
                pointsFollowed.RemoveAt(0);
            }
            pointsFollowed.Add(GameObj.Transform.Pos.Xy);
        }
    }
}
