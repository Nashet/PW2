using System.Collections.Generic;
using PW2.Scripts.CommonUtilities;
using PW2.Scripts.Services.Interfaces;

namespace PW2.Scripts.Services
{
	public class ServiceManager : Singleton<ServiceManager>
	{
		private readonly List<IService> services = new List<IService>();
		private static bool initialized = false;
		//[Inject] private readonly ILogService logService;
		
		public ServiceManager()
		{
			//_requestManager = new RequestManager();

			if (initialized)
				return;
			// Add all services here
			Add<WorldDescriberService>();
			Add<WorldLoaderService>();
			Add<LogService>();
			initialized = true;
			//_ready = true;
			//logService.Log("Is done");
		}

		public T Get<T>() where T : class, IService
		{
			foreach (var t in services)
			{
				if (t is T service)
				{
					return service;
				}
			}

			//MLogger.LogWarningFormat("No service registered of type {0}",typeof(T));
			return null as T;
		}

		private void Add<T>() where T : class, IService, new()
		{
			services.Add(new T());
		}
	}
}