// using System.Collections.Generic;
//
// namespace DefaultNamespace
// {
//     public interface IProducer : IStorage
//     {
//         Product Product { get; }
//         decimal Produce(decimal workforce);
//         Storage Storage { get; }
//        
//     }
//
//     public class Producer : Storage, IProducer
//     {
//         private readonly Storage _storage;
//         public Product Product { get; }
//         
//         public decimal Produce(decimal workforce)
//         {
//             var eff = ModelResolver.Resolve<BasicEfficiency>().Efficiency[Product];
//             var produced = eff * workforce;
//             return produced;
//         }
//
//         public Storage Storage => _storage;
//
//         public Producer(Product type, decimal amount) : base(type, amount)
//         {
//         }
//     }
//
//     public class BasicEfficiency : IModel
//     {
//         public readonly IReadOnlyDictionary<Product, decimal> Efficiency = new Dictionary<Product, decimal>();
//     }
// }