using Duality;

namespace MFEP.Duality.Plugins.Animation.Sample
{
	public class WritePercentComp : Component, ICmpAnimUpdateable
	{
		public void AnimTickCallback (float currentPercent)
		{
			Log.Game.Write ($"Current animation percent is: {currentPercent}");
		}
	}
}
