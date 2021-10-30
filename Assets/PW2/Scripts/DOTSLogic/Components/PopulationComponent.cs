using System;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    [GenerateAuthoringComponent]
	[Serializable]
	public struct PopulationComponent : IComponentData
	{
		public int PopulationSize;
    }
}