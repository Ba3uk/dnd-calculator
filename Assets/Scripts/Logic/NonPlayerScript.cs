using Logic.Atributs;
using System.Collections.Generic;
using UnityEngine;

namespace Logic
{
    public class NonPlayerScript : Character
	{
		public NonPlayerScript(string Title, Abilities Abilities, int ClassHealthMultiplier)
			: base(Title, Abilities, ClassHealthMultiplier)
		{
			Conditions = new List<ICondition>(); // хйня для теста!! потом удалить
		}

		public override List<Item> Inventory { get; set; }

		public override void AttackRoll(int Dice, Atribute Atribute, IAttack Attack)
		{
			if (Random.Range(1, Dice) + Atribute.CheckModifier > Attack.Target.Abilities.ArmorClass)
			{
				Debug.Log("You hit an opponent!");
				Attack.AttackAction();
			}
			else
			{
				Debug.Log("You Missed :(");
			}
		}

		public override void SaveRoll(int Dice, int Difficulty, Atribute Atribute) { }

		public override void DamageRoll(IAttack Attack) { }
	}
}