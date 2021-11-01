// using PW2.Scripts.DOTSLogic.Components;
// using Unity.Entities;
//
// namespace PW2.Scripts.DOTSLogic.Systems
// { 
// 	public class AddEntitiesSystem : SystemBase 
// 	{
// 		private int entitiesToCreate = 10;
//
// 		protected override void OnCreate()
// 		{
// 			//EntityManager.DestroyEntity(m_Query);
// 			while (entitiesToCreate > 0)
// 			{
// 				var entity = EntityManager.CreateEntity();
// 				EntityManager.AddComponentData(entity, new PopulationComponent() {PopulationSize = 1000});
// 				EntityManager.AddComponentData(entity, new StorageComponent());
// 				EntityManager.AddComponentData(entity, new ProductionComponent() {});//ProductType = 42, ProductionRate = 0.002f
// 				//logService.Log("created entity " + entity.Index);
// 				//ServiceManager.Instance.Get<LogService>()
// 				entitiesToCreate--;
// 			}
//
// 			{
// 				// is market
// 				var entity = EntityManager.CreateEntity();
// 				EntityManager.AddComponentData(entity, new StorageComponent());
// 				EntityManager.AddComponentData(entity, new MarketComponent()); 
// 			}
// 		}
//
// 		protected override void OnUpdate()
// 		{
// 			
// 		}
// 	}
// }