using Duality;
using Duality.Editor;

namespace MFEP.Duality.Plugins.Animation.Sample
{
    [EditorHintCategory (ResNames.EditorCategory)]
	public class WritePercentComp : Component, ICmpAnimUpdateable
	{
		public void AnimTickCallback (float currentPercent)
		{
			Log.Game.Write ($"Current animation percent is: {currentPercent}");
		}
	}
}
