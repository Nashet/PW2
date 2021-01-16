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
}