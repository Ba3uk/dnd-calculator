using UnityEngine;

namespace OldLogic
{
	class MartialAttack<TAttribute> : IAttack
		where TAttribute : Atribute
	{
		public Weapon Weapon { get; set; }
		public Character Target { get; set; }
		public Atribute Save { get; set; }
		public ICondition Condition { get; set; }

		public MartialAttack(Character Target, Weapon Weapon)
		{
			this.Weapon = Weapon;
			this.Target = Target;
		}

		/*
		public MartialAttack(Character Target, Weapon Weapon, Atribute Save)
			: this(Target, Weapon) // как реализовать третий параметр по нормальному..? 50/50 решено
		{
			this.Save = Save;
		}
		*/

		public void AttackAction()
		{
			if (Target.Abilities.TryGetAtribute(out TAttribute attribute)) { }

			int finalDamage =
				(int) Mathf.Round(Weapon.Damage.Value *
								Target.Abilities.Resistances
									[Weapon.Damage.DamageType]); // это мне не нравится, нужно переделать чтобы перенести устойчивость в TakeDamage?

			Target.TakeDamage(finalDamage);

			Debug.Log($"Dealt damage: {finalDamage}");
		}
	}
}

/*public MartialAttack(Character Target, Weapon Weapon, ICondition Condition, Atribute Save) : this(Target, Weapon, Save)
	{
		this.Condition = Condition;
	}
	public MartialAttack(Character Target, Weapon Weapon, ICondition Condition) : this(Target, Weapon)
	{
		this.Condition = Condition;
	}*/