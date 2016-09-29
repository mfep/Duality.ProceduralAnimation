using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	[EditorHintCategory (ResNames.EditorCategory)]
	public class CustomComponentUpdateSample : AnimResource
	{
		protected override AnimBuilder InitializePieces ()
		{
			return AnimBuilder.Start ()
				.AddParalell (new IAnimPiece[]
				{
					new SimpleMovement { EndPos = new Vector2 (500, 0) },
					new CustomComponentUpdate<WritePercentComp> ()
				}, 5.0f);
		}
	}
}