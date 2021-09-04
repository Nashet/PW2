using PW2.Scripts.Services.Interfaces;
using UnityEngine;

namespace PW2.Scripts.Services
{
	public class LogService : ILogService, IService
	{
		public void Log(string text)
		{
			Debug.LogError(text);
		}
	}
	// public class TestInstaller : MonoInstaller
	// {
	// 	public override void InstallBindings()
	// 	{
	// 		Container.Bind<string>().FromInstance("Hello World!");
	// 		Container.Bind<Greeter>().AsSingle().NonLazy();
	// 	}
	// }
}