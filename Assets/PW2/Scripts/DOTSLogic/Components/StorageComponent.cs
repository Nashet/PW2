using System;
using System.Collections.Generic;
using PW2;
using Unity.Collections;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    [Serializable]
    public struct StorageComponent : IComponentData
    {
        //public readonly NativeArray<decimal> Items;  

        public StorageComponent(Product type, decimal amount)
        {
            //Items = new NativeArray<decimal>(34, Allocator.Persistent);
            
            // has = new NativeHashMap<byte, decimal>();
            // Add(type, amount);
        }

        // public decimal this[Product index]
        // {
        //     // get => has[index.Id];
        //     // set => has[index.Id] = value;
        // }

        // public void Add(Product type, decimal amount)
        // {
        //     if (has.ContainsKey(type.Id))
        //         this[type] = this[type] + amount;
        //     else
        //     {
        //         has.Add(type.Id, amount);
        //     }
        // }
    }
}