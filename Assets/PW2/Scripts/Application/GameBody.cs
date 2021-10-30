using System;
using PW2.Scripts.Services;

namespace PW2.Scripts.Application
{
    public class GameBody : MyMono
    {
        private void Update()
        {
            //ecs run by it self
            //ServiceManager.Instance.Get<SimulationService>().Step();
        }

        private void Start()
        {
            var s = ServiceManager.Instance.Get<PrepareGame>();
            s.Prepare();
        }
    }
}