using System;
using Unity.Collections;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    [Serializable]
    public struct MarketComponent : IComponentData
    {
        public int trades;
        //public readonly NativeArray<Single> Prices;
        public float Rt;
        public NativeList<float> df;
        public MarketComponent(float[] prices)
        {
            df = new NativeList<float>();
            //Prices = prices; 
            Rt = 3;
            // has = new NativeHashMap<byte, decimal>();
            // Add(type, amount);
            trades = 0;
        }
    }
}