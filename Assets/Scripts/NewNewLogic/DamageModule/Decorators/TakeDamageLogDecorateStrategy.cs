using NewNewLogic.HealthModule;
using OldLogic;
using System.Collections.Generic;
using UnityEngine;

namespace NewNewLogic.DamageModule.Decorators
{
	public class TakeDamageLogDecorateStrategy : ITakeDamageStrategy
	{
		private readonly ITakeDamageStrategy _innerTakeDamageStrategy;
		private readonly HealthProvider _healthProvider;

		public TakeDamageLogDecorateStrategy(ITakeDamageStrategy InnerTakeDamageStrategy, HealthProvider HealthProvider)
		{
			_healthProvider = HealthProvider;
			_innerTakeDamageStrategy = InnerTakeDamageStrategy;
		}

		public void TakeDamage(Character Character, Damage damage)
		{
			if (!_healthProvider.TryGetCharacterHealth(Character.ID, out var health))
			{
				return;
			}

			var healthBeforeDamage = health.CurrentValue;
			_innerTakeDamageStrategy.TakeDamage(Character, damage);
			var delta = healthBeforeDamage - health.CurrentValue;
			Debug.Log($"character with id = '{Character.ID}' take damage = {delta}");
		}

		public void TakeDamageGroup(List<Character> Characters, Damage damage)
		{
			foreach (var character in Characters)
			{
				TakeDamage(character, damage);
			}
		}
	}
}