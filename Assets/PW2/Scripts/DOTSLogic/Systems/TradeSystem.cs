using PW2.Scripts.DOTSLogic.Components;
using Unity.Burst;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Systems
{
	[BurstCompile]
	public class TradeSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			Entities
				.ForEach((ref StorageComponent storage, in ProductionComponent production, in PopulationComponent population) =>
				{
					//send to market and get money
				})
				.ScheduleParallel();
		}
	}
}