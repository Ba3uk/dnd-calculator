using Logic.Atributs;
using System.Collections.Generic;
using UnityEngine;

namespace Logic


{
	public class playerScript : Character
	{
		public playerScript(string Title, Abilities Abilities, int ClassHealthMultiplier)
			: base(Title, Abilities, ClassHealthMultiplier) { }

		public override List<Item> Inventory { get; set; }

		public override void AttackRoll(int Dice, Atribute Atribute, IAttack Attack)
		{
			int Roll = Random.Range(1, Dice) +
						Atribute.CheckModifier; // как оптимально выводить значение на консоль и использовать его сразу же, не создавая буфферную переменную и есть ли в этом смысл?

			if (Roll > Attack.Target.Abilities.ArmorClass)
			{
				Debug.Log("You hit an opponent!");
				Attack.AttackAction();
			}
			else
			{
				Debug.Log($"You Missed :(\nYour roll was {Roll} and enemy's AC was {Attack.Target.Abilities.ArmorClass}");
			}
		}

		public override void SaveRoll(int Dice, int Difficulty, Atribute Save)
		{
			// неясно пока как реализовать, в каком классе и как передавать выбранную характеристику для проверки
		}

		public override void DamageRoll(IAttack Attack) { }

		// стоит ли перенести реализацию этих методов (атак и тэйкдэмэдж) в родительский класс?
	}
}