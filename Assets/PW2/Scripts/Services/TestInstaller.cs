using PW2.Scripts.Services.Interfaces;
using UnityEngine;
using Zenject;

namespace PW2.Scripts.Services
{
	public class TestInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<string>().FromInstance("Hello World!");
			Container.Bind<Greeter>().AsSingle().NonLazy();
			Container.Bind<ILogService>().To<LogService>().AsSingle();
		}
	}

	public class Greeter
	{
		public Greeter(string message)
		{
			Debug.LogError(message);
		}
	}
}