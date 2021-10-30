using PW2.Scripts.Services.Interfaces;

namespace PW2.Scripts.Services
{
    public class PrepareGame :  IService
    {
        public void Prepare()
        {
            var s = ServiceManager.Instance.Get<WorldGeneratorService>();
            s.Generate();
        }
    }
}