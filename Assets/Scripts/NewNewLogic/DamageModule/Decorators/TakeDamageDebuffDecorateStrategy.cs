using OldLogic;
using System.Collections.Generic;

namespace NewNewLogic.DamageModule.Decorators
{
	public class TakeDamageDebuffDecorateStrategy : ITakeDamageStrategy
	{
		public void TakeDamage(Character Character, Damage damage)
		{
			throw new System.NotImplementedException();
		}

		public void TakeDamageGroup(List<Character> Characters, Damage damage)
		{
			throw new System.NotImplementedException();
		}
	}
}