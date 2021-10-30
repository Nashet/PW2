using System;
using System.Collections.Generic;
using PW2;
using PW2.Scripts.CommonUtilities;
using PW2.Scripts.DOTSLogic.Components;
using PW2.Scripts.Services;
using PW2.Scripts.Services.Interfaces;
using Unity.Collections;
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
            EntityManager.AddComponentData(country, new MarketComponent(new float[3]{1f, 1f, 1f}));
            EntityManager.SetName(country, "Country");
            return country;
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
            EntityManager.AddComponentData(pop, new StorageComponent());
            EntityManager.AddComponentData(pop, new ProductionComponent());
            EntityManager.AddComponentData(pop, new ParentComponent {Id = provinceId, Parent = parent});
            EntityManager.SetName(pop, "Pop");
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