using System;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    [Serializable]
    public struct MarketComponent : IComponentData
    {
        public int delData;
        public MarketComponent(int none)
        {
            delData = 42;

        }
    }
}