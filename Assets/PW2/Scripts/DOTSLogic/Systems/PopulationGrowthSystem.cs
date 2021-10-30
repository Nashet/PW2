using PW2.Scripts.DOTSLogic.Components;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;

namespace PW2.Scripts.DOTSLogic.Systems
{
    public class PopulationGrowthSystem : JobComponentSystem
    {
        //[ExcludeComponent(typeof(LbFall))]
        [BurstCompile]
        public struct PopulationJob : IJobForEach<PopulationComponent>
        {
            public float GrowthRate;

            public void Execute(ref PopulationComponent target)
            {
                target.PopulationSize += (int) (target.PopulationSize * GrowthRate);
                //ServiceManager.Instance.Get<LogService>().Log("Population is " + target.PopulationSize);
            }
        }

        protected override JobHandle OnUpdate(JobHandle handler)
        {
            var handle = new PopulationJob()
            {
                GrowthRate = 0.001f,
            }.Schedule(this, handler);
            return handle;
        }
    }
}
