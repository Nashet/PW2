using PW2.Scripts.DOTSLogic.Components;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;

namespace PW2.Scripts.DOTSLogic.Systems
{
    public class ProduceValueSystem : JobComponentSystem
    {
        [BurstCompile]
        [RequireComponentTag(typeof(StorageElement))]
        struct Job : IJobForEachWithEntity<StorageComponent, ProductionComponent, PopulationComponent>
        {
            // Allow buffer read write in parralel jobs
            // Ensure, no two jobs can write to same entity, at the same time.
            // !! "You are somehow completely certain that there is no race condition possible here, because you are absolutely certain that you will not be writing to the same Entity ID multiple times from your parallel for job. (If you do thats a race condition and you can easily crash unity, overwrite memory etc) If you are indeed certain and ready to take the risks.
            // https://forum.unity.com/threads/how-can-i-improve-or-jobify-this-system-building-a-list.547324/#post-3614833
            [NativeDisableParallelForRestriction] public BufferFromEntity<StorageElement> bufferFromEntity;

            public void Execute(Entity entity, int index, ref StorageComponent someName, ref ProductionComponent production, ref PopulationComponent population)
            {
                var productionType = production.type;

                var produced = production.ProductionRate * population.PopulationSize;
                
                var storage = bufferFromEntity[entity];
                storage.Clear();
                storage.Add(new StorageElement((FixedString64)productionType.ToString(), produced));
                Debug.Log("#" + index + "; " + storage[0].Amount + "; " + storage[0].Id);
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            var job = new Job()
            {
                bufferFromEntity = GetBufferFromEntity<StorageElement>(false)
            };
            return job.Schedule(this, inputDeps);
        }
    }
}