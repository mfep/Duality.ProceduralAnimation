using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.RealWorldExampleCategory)]
	public abstract class StepRes : AnimResource
	{
		public float StepSize { get; set; } = 64;
		public float StepTime { get; set; } = 0.25f;

		protected abstract Vector2 Direction { get; }

		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.Add (new SimpleMovement { EndPos = StepSize * Direction }, StepTime);
		}
	}

	public class StepLeft : StepRes
	{
		protected override Vector2 Direction => new Vector2 (-1, 0);
	}

	public class StepRight : StepRes
	{
		protected override Vector2 Direction => new Vector2 (1, 0);
	}

	public class StepUp : StepRes
	{
		protected override Vector2 Direction => new Vector2 (0, -1);
	}

	public class StepDown : StepRes
	{
		protected override Vector2 Direction => new Vector2 (0, 1);
	}
}