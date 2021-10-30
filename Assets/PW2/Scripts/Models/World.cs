// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.CompilerServices;
// using DefaultNamespace;
//
// namespace DefaultNamespace
// {
//     public interface IWorld : IModel
//     {
//         IEnumerable<IProvince> Provinces { get; }
//         IEnumerable<IProducer> Producers { get; }
//         IEnumerable<IConsumer> Consumers { get; }
//         IEnumerable<IPopUnit> Pops { get; }
//         IEnumerable<IFactory> Factories { get; }
//     }
//
//     public class World : IWorld
//     {
//         public IEnumerable<IProvince> Provinces { get; private set; } = new List<IProvince>();
//
//         public IEnumerable<IProducer> Producers { get; private set; } = new List<IProducer>();
//
//         public IEnumerable<IConsumer> Consumers { get; private set; } = new List<IConsumer>();
//
//         public IEnumerable<ISeller> AllSellers { get; private set; } = new List<ISeller>();
//         public IEnumerable<IAgent> AllAgents { get; private set; } = new List<IAgent>();
//         public IEnumerable<IPopUnit> Pops { get; private set; } = new List<IPopUnit>();
//         public IEnumerable<IFactory> Factories { get; private set; } = new List<IFactory>();
//
//         public int TryGetPopulation()
//         {
//             return Provinces.Sum(x => x.Population);
//         }
//
//         public IEnumerable<Country> AllExistingCountries()
//         {
//             throw new System.NotImplementedException();
//         }
//         
//         // public IEnumerable<Market> AllMarkets()
//         // {
//         //     throw new System.NotImplementedException();
//         // }
//         //
//         // public IEnumerable<Factory> AllCultures()
//         // {
//         //     throw new System.NotImplementedException();
//         // }
//         //
//         // public Money GetAllMoney()
//         // {
//         //     throw new System.NotImplementedException();
//         // }
//     }
//
//
//     public interface IConsumer
//     {
//     }
//
//    
//
//     public interface IAgent
//     {
//     }
//
//     public interface ISeller
//     {
//     }
// }