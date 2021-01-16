using System;
using JetBrains.Annotations;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
	[Serializable]
	public struct StorageComponent : IComponentData
	{
		public float Amount;
		public int ProductType;
	}

	public class Product
	{
		public static Product getRandomResource(bool b)
		{
			throw new NotImplementedException();
		}
	}
}