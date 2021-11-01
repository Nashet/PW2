using System.ComponentModel;
using PW2.Scripts.DOTSLogic.Components;
using Unity.Entities;
using UnityEngine;


// namespace PW2.Scripts.DOTSLogic.Systems
// {
//     [BurstCompile]
//     public class TradeSystem : SystemBase
//     {
//         struct PlayerData {
//             public readonly int Length;
//             public ComponentDataArray<Health> health;
//             [ReadOnly] public ComponentDataArray<TeamAssignment> teamAssignment;
//         }
//         [Inject] PlayerData playerData;
//         [Inject] ComponentDataFromEntity<Team> teams;
//  
//         protected override void OnUpdate()
//         {
//             for(var i = 0; i < playerData.Length; i++)
//             {
//                 var health = playerData.health[i];
//                 var team = teams[playerData.teamAssignment[i].Entity];
//                 // blabla
//             }
//         }
//     }
// }

namespace PW2.Scripts.DOTSLogic.Systems
{
    //[BurstCompile]
    public class TradeSystem : SystemBase
    {
        // struct PlayerData {
        //     public readonly int Length;
        //     public ComponentDataArray<Health> health;
        //     [ReadOnly] public ComponentDataArray<TeamAssignment> teamAssignment;
        // }
        // [Inject] PlayerData playerData;
        // [Inject] ComponentDataFromEntity<Team> teams;

        protected override void OnUpdate()
        {
            var owner = GetComponentDataFromEntity<ParentComponent>();
            var marketGetter = GetComponentDataFromEntity<MarketComponent>();
            Entities
                .WithReadOnly(owner)
                .ForEach((Entity entity, in ProductionComponent production, in ParentComponent province) =>
                {
                    var prov = owner[province.Parent];

                    var market = marketGetter[prov.Parent];

                    market.trades = market.trades++;
                   // Debug.LogError("Trade is" + market.trades.ToString());

                })
                .Schedule();
        }
    }
}