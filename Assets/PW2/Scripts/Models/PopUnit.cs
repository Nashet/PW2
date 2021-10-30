// namespace DefaultNamespace
// {
//     public interface IPopulatable
//     {
//         int Population { get; }
//     }
//
//     public interface IPopUnit : IConsumer, IPopulatable, IProducer
//     {
//     }
//
//     public class PopUnit : Producer, IPopUnit
//     {
//         private IPopUnit _popUnitImplementation;
//         int IPopulatable.Population { get; }
//
//         public PopUnit(Product type, decimal amount) : base(type, amount)
//         {
//         }
//     }
// }