using System;
using System.Collections.Generic;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Components
{
    // public interface IStorage
    // {
    //     decimal this[Product index] { get; }
    //     //void Add(Product product, decimal amount);
    // }
    //
    // public class Storage : IStorage
    // {
    //     private readonly Dictionary<Product, decimal> Has;
    //
    //     public Storage(Product type, decimal amount)
    //     {
    //         Has = new Dictionary<Product, decimal> {{type, amount}};
    //     }
    //     
    //     public Storage()
    //     {
    //         Has = new Dictionary<Product, decimal>();
    //     }
    //
    //
    //     // public decimal this[Product index]
    //     // {
    //     //     get => Has[index];
    //     //     internal set { Has[index] = value; }
    //     // }
    //
    //     public decimal this[Product index]
    //     {
    //         get => Has[index];
    //         set => Has[index] = value;
    //     }
    // }
    
	[Serializable]
	public struct ProductionComponent : IComponentData
    {
        //public Storage Storage;
		public decimal ProductionRate;
        //public decimal Money;
		//public PW2.Product Product;
        public Products type;

        public ProductionComponent(decimal productionRate, Products productType)
        {
            // Storage = new Storage();
            // ProductionRate = productionRate;
            // ProductType = productType;
            //Money = 0m;
            type = productType;
            ProductionRate = productionRate;
        }
    }
}