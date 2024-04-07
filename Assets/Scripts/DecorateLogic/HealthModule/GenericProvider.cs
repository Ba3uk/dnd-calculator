using System.Collections.Generic;
using UnityEngine;

namespace DecorateLogic.HealthModule
{
	public class GenericProvider<TKey, TComponent>
	{
		protected Dictionary<TKey, TComponent> _healths;

		public void Register(TKey key, TComponent Health)
		{
			if (!_healths.TryAdd(key, Health))
			{
				Debug.LogError($"Health with id = {key} added before");
			}
		}

		public void UnRegister(TKey key)
		{
			if (!_healths.Remove(key))
			{
				Debug.LogError($"Health with id = {key} removed before");
			}
		}

		public bool TryGetCharacterHealth(TKey key, out TComponent health)
		{
			return _healths.TryGetValue(key, out health);
		}
	}
}