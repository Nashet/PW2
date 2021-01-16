using PW2.Scripts.DOTSLogic.Components;
using Unity.Burst;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Systems
{
	[BurstCompile]
	public class ProduceValueSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			Entities
				.ForEach((ref StorageComponent storage, in ProductionComponent production, in PopulationComponent population) =>
				{
					var produced = population.PopulationSize * production.ProductionRate;
					storage.ProductType = production.ProductType;
					storage.Amount += produced;
				})
				.ScheduleParallel();
		}
	}
}