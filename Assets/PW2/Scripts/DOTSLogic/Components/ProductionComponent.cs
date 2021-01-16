using System;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
	[Serializable]
	public struct ProductionComponent : IComponentData
	{
		public float ProductionRate;
		public int ProductType;
	}
}