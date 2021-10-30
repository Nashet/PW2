// using System.Collections.Generic;
//
// namespace DefaultNamespace
// {
//     public interface IStorage
//     {
//         decimal this[Product index] { get; }
//         //void Add(Product product, decimal amount);
//     }
//
//     public class Storage : IStorage
//     {
//         private readonly Dictionary<Product, decimal> Has;
//
//         public Storage(Product type, decimal amount)
//         {
//             Has = new Dictionary<Product, decimal> {{type, amount}};
//         }
//
//
//         // public decimal this[Product index]
//         // {
//         //     get => Has[index];
//         //     internal set { Has[index] = value; }
//         // }
//
//         public decimal this[Product index]
//         {
//             get => Has[index];
//             set => Has[index] = value;
//         }
//     }
// }