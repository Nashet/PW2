using PW2.Scripts.DOTSLogic.Components;
using PW2.Scripts.Services;
using Unity.Entities;

namespace PW2.Scripts.DOTSLogic.Systems
{
	public class AddEntitiesSystem : SystemBase 
	{
		//EntityQuery m_Query;
		private int entitiesToCreate = 100;  

		protected override void OnCreate()
		{
			//checks if component already present
			//m_Query = GetEntityQuery(typeof(LbGameStart));
			//ServiceManager.Instance.Get<LogService>().Log("created entity " + entity.Index);
		}

		/// <summary>
		/// Update the game
		/// </summary>
		protected override void OnUpdate()
		{
			//EntityManager.DestroyEntity(m_Query);
			while (entitiesToCreate > 0)
			{
				var entity = EntityManager.CreateEntity();
				EntityManager.AddComponentData(entity, new PopulationComponent() {PopulationSize = 1000});
				EntityManager.AddComponentData(entity, new StorageComponent());
				EntityManager.AddComponentData(entity, new ProductionComponent() {ProductType = 42, ProductionRate = 0.002f});
				ServiceManager.Instance.Get<LogService>().Log("created entity " + entity.Index);
				entitiesToCreate--;
			}

			{
				var entity = EntityManager.CreateEntity();
				EntityManager.AddComponentData(entity, new StorageComponent()); // is market
			}
		}
	}
}