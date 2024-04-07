using UnityEngine;

namespace Logic
{
	public class TestController : MonoBehaviour
	{
		playerScript player = new playerScript("Alex",
			new Abilities(new Strength(18),
				new Dexterity(14),
				new Constitution(14),
				new Intelegence(14),
				new Wisdom(14),
				new Charisma(14)),
			3);

		NonPlayerScript enemy = new NonPlayerScript("Cobold",
			new Abilities(new Strength(14),
				new Dexterity(14),
				new Constitution(20),
				new Intelegence(14),
				new Wisdom(14),
				new Charisma(14)),
			2);

		Weapon Rapier = new Weapon(03,
			"Rapier",
			true,
			new Damage(DamageType.Piercing, 8),
			12,
			"Cool pointy stick",
			1222);

		void Start()
		{
			enemy.Abilities.Resistances[DamageType.Piercing] = 0.75f;
		}

		public void Test()
		{
			player.AttackRoll(20, player.Abilities.Strength, new MartialAttack<Strength>(enemy, Rapier));
		}
	}
}