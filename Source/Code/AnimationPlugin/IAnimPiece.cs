using System;
using Duality;

namespace ProceduralAnimation
{
	public interface IAnimPiece
	{
		void Tick (float percent, GameObject gameObject);
	}
}
