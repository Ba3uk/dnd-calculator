using System.Collections.Generic;

namespace Assets.Scripts.MainLogic.AttackLogic
{
	public interface ITakeDamage
	{
		public void TakeDamage(Character character, Damage damage);
		public void TakeGroupDamage(List<Character> characters, Damage damage);
	}
}