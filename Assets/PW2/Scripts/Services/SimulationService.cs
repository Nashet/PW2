
using PW2;
using PW2.Scripts.Services.Interfaces;


namespace PW2.Scripts.Services
{
    public class SimulationService : IService
    {
        //private IWorld _world = null;

        public SimulationService()
        {
           // _world = ModelResolver.Resolve<IWorld>();
        }

        public void Step()
        {
            DoGrowth();
            DoProduction();
            DoTrade();
            DoCinsumption();
        }

        private void DoCinsumption()
        {
            throw new System.NotImplementedException();
        }

        private void DoTrade()
        {
            throw new System.NotImplementedException();
        }

        private void DoGrowth()
        {
            // foreach (var item in _world.Pops)
            // {
            //     Changer.Instance.UpdatePopulation(item, item.Population + 12);
            // }
        }

        private void DoProduction()
        {
            // foreach (var item in _world.Producers)
            // {
            //     var population = 0;
            //     if (item is IPopUnit unit)
            //     {
            //         population = unit.Population;
            //     }
            //     else if (item is IFactory factory)
            //     {
            //         population = factory.Workforce;
            //     }
            //
            //     var amount = item.Produce(population);
            //     Changer.Instance.UpdateStorage(item, item.Product, amount);
            // }
        }
    }
}