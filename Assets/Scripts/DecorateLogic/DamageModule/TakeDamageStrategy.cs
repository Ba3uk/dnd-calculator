using DecorateLogic.HealthModule;
using Logic;
using System.Collections.Generic;

namespace DecorateLogic.DamageModule
{
    public class TakeDamageStrategy : ITakeDamageStrategy
	{
		private readonly HealthProvider _healthProvider;

		public TakeDamageStrategy(HealthProvider HealthProvider)
		{
			_healthProvider = HealthProvider;
		}

		public void TakeDamage(Character Character, Damage damage)
		{
			if (!_healthProvider.TryGetCharacterHealth(Character.ID, out var health))
			{
				return;
			}

			health.TakeDamage(damage.Value);
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