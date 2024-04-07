using OldLogic;
using System.Collections.Generic;

namespace NewNewLogic.DamageModule
{
	public interface ITakeDamageStrategy
	{
		void TakeDamage(Character Character, Damage damage);
		void TakeDamageGroup(List<Character> Characters, Damage damage);
	}
}