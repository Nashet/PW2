using System.Collections.Generic;
using PW2.Scripts.CommonUtilities;
using PW2.Scripts.Services.Interfaces;
using Zenject;

namespace PW2.Scripts.Services
{
	public class ServiceManager : Singleton<ServiceManager>
	{
		private readonly List<IService> services = new List<IService>();
		private bool initialized = false;
		private readonly ILogService logService = default;//[Inject] 

        public ServiceManager()
		{
			//_requestManager = new RequestManager();

			if (initialized)
				return;
			// Add all services here
			//Add<WorldDescriberService>();
            logService = Add<LogService>();
            Add<SimulationService>();
            Add<WorldGeneratorService>();
            Add<PrepareGame>();
			initialized = true;
			//_ready = true;
			logService.Log("ServiceManager Is ready");
		}

		public T Get<T>() where T : class, IService
		{
            //if (Instance == null)
                
			foreach (var t in services)
			{
				if (t is T service)
				{
					return service;
				}
			}

			//MLogger.LogWarningFormat("No service registered of type {0}",typeof(T));
			return null;
		}

		private T Add<T>() where T : class, IService, new()
        {
            var s = new T();
            services.Add(s);
            return s;
        }
	}
}