// namespace DefaultNamespace
// {
//     public interface IFactory : IProducer
//     {
//         int Workforce { get;  }
//     }
//     
//     public class Enterprise : Producer, IFactory
//     {
//         public Product Product { get; }
//         public decimal Produce(decimal workforce)
//         {
//             throw new System.NotImplementedException();
//         }
//
//         public Storage Storage { get; }
//
//
//         decimal IStorage.this[Product index]
//         {
//             get => Storage[index];
//         }
//
//         public int Workforce { get; }
//
//         public Enterprise(Product type, decimal amount) : base(type, amount)
//         {
//         }
//     }
//     
// }