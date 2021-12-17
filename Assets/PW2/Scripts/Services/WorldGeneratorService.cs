using System;
using System.Linq;
using PW2.Scripts.DOTSLogic.Components;
using PW2.Scripts.Services.Interfaces;
using Unity.Entities;

namespace PW2.Scripts.Services
{
    public class WorldGeneratorService : SystemBase, IWorldGeneratorService, IService
    {
        private static bool needToGenerate = false;

        public void Generate()
        {
            needToGenerate = true;
        }

        void ReallyGenerate()
        {
            int popsToGenerate = 5;
            int provinceAmount = 3;
            int countryAmount = 2;
            int idCounter = 0;

            for (var x = 0; x < countryAmount; x++)
            {
                var country = GenerateCountry(idCounter);
                var countryId = idCounter;
                idCounter++;
                for (var j = 0; j < provinceAmount; j++)
                {
                    var province = GenerateProvince(idCounter, countryId, country);
                    idCounter++;
                    for (var i = 0; i < popsToGenerate; i++)
                    {
                        GeneratePop(idCounter, province);
                        idCounter++;
                    }
                }
            }
        }

        private Entity GenerateCountry(int idCounter)
        {
            var country = EntityManager.CreateEntity();
            EntityManager.AddComponentData(country, new CountryComponent());
            CreateMarket(country);
            EntityManager.SetName(country, "Country");
            return country;
        }

        private void CreateMarket(Entity entity)
        {
            var market = new MarketComponent();
            EntityManager.AddComponentData(entity, market);
            EntityManager.SetComponentData(entity, market);
            CreateStorage(entity);
        }

        private void CreateStorage(Entity entity)
        {
            EntityManager.AddComponentData(entity, new StorageComponent());
            EntityManager.AddBuffer<StorageElement>(entity);
            // Add some items to storage
            // var items = EntityManager.GetBuffer<StorageElement>(entity);
            // items.Add(new StorageElement("Sword"));
            // items.Add(new StorageElement("Shield"));
            // items.Add(new StorageElement("Coins"));
        }

        private Entity GenerateProvince(int provinceId, int countryId, Entity parent)
        {
            var province = EntityManager.CreateEntity();
            EntityManager.AddComponentData(province, new ParentComponent {Id = provinceId, Parent = parent});
            //EntityManager.AddComponentData(province, new CountryComponent());
            EntityManager.SetName(province, "province ");
            return province;
        }

        private Entity GeneratePop(int provinceId, Entity parent)
        {
            var pop = EntityManager.CreateEntity();
            EntityManager.AddComponentData(pop, new PopulationComponent {PopulationSize = 1000});

            var array = Enum.GetValues(typeof(Products));
            var randomProduct = array.GetValue(UnityEngine.Random.Range(0, array.Length - 1));
            
            EntityManager.AddComponentData(pop, new ProductionComponent(0.001m, (Products)randomProduct));
            EntityManager.AddComponentData(pop, new ParentComponent {Id = provinceId, Parent = parent});
            EntityManager.SetName(pop, "Pop");
            CreateStorage(pop);
            // EntityManager.AddComponentData(pop, new ProductionComponent {Product = Product.allProducts.Random(), ProductionRate = 0.002m});
            //logService.Log("created entity " + entity.Index);
            //ServiceManager.Instance.Get<LogService>()
            return pop;
        }

        protected override void OnUpdate()
        {
            if (needToGenerate)
            {
                ReallyGenerate();
                needToGenerate = false;
            }
        }
    }
}