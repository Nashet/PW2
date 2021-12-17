using PW2.Scripts.DOTSLogic.Components;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;

public class TradeSystem : JobComponentSystem
{
    [BurstCompile]
    [RequireComponentTag(typeof(StorageElement))]
    struct Job : IJobForEachWithEntity<StorageComponent>
    {
        // Allow buffer read write in parralel jobs
        // Ensure, no two jobs can write to same entity, at the same time.
        // !! "You are somehow completely certain that there is no race condition possible here, because you are absolutely certain that you will not be writing to the same Entity ID multiple times from your parallel for job. (If you do thats a race condition and you can easily crash unity, overwrite memory etc) If you are indeed certain and ready to take the risks.
        // https://forum.unity.com/threads/how-can-i-improve-or-jobify-this-system-building-a-list.547324/#post-3614833
        [NativeDisableParallelForRestriction] public BufferFromEntity<StorageElement> bufferFromEntity;

        public void Execute(Entity entity, int index, ref StorageComponent someName)
        {
            //execute only for given country
            var prices = bufferFromEntity[entity];
            
            Debug.Log("#Trade" + index + "; " + prices[0].Amount + "; " + prices[0].Id);
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

// namespace PW2.Scripts.DOTSLogic.Systems
// {
//     public class TradeSystem : SystemBase
//     {
//         protected override void OnUpdate()
//         {
//             // var owner = GetComponentDataFromEntity<ParentComponent>();
//             // var marketGetter = GetComponentDataFromEntity<MarketComponent>();
//             // Entities
//             //     .WithReadOnly(owner)
//             //     .ForEach((Entity entity, in ProductionComponent production, in ParentComponent province) =>
//             //     {
//             //         var prov = owner[province.Parent];
//             //
//             //         var market = marketGetter[prov.Parent];
//             //
//             //         Debug.LogError("Trade is" );
//             //
//             //     })
//             //     .Schedule();
//         }
//     }
// }