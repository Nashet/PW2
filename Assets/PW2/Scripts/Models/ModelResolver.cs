// using System;
// using System.Collections.Generic;
//
// namespace DefaultNamespace
// {
//     public interface IModel
//     {
//     }
//     
//     public static class ModelResolver
//     {
//         private static readonly Dictionary<Type, IModel> sharedComponents = new Dictionary<Type, IModel>();
//
//         static ModelResolver()
//         {
//             sharedComponents.Add(typeof(IWorld), new World());
//             sharedComponents.Add(typeof(BasicEfficiency), new BasicEfficiency());
//         }
//
//         public static T Resolve<T>() where T : IModel
//         {
//             return (T) sharedComponents[typeof(T)];
//         }
//     }
// }