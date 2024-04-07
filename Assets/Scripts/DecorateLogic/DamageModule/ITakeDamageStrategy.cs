using Logic;
using System.Collections.Generic;

namespace DecorateLogic.DamageModule
{
	public interface ITakeDamageStrategy
	{
		void TakeDamage(Character Character, Damage damage);
		void TakeDamageGroup(List<Character> Characters, Damage damage);
	}
}