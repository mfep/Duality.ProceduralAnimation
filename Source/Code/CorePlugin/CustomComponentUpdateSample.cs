using Duality;
using Duality.Editor;
using MFEP.Duality.Plugins.Animation.AnimPieces;
using MFEP.Duality.Plugins.Animation.Sample.Properties;

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
					new SimpleMovement { EndPos = new Vector2 (2500, 0) },
					new CustomComponentUpdate<WritePercentComp> (),
					new CallbackProvider
					{
						Callback = (pc, go) =>
						{
							if (pc > 0.7f) go.Transform.Pos += Vector3.UnitY * 3.0f;
						}
					}
				}, 3.0f);
		}
	}
}