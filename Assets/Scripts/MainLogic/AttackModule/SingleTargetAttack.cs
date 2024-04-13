﻿using Assets.Scripts.MainLogic.AttackModule;
using System.Collections.Generic;

namespace Assets.Scripts.MainLogic
{
	public class SingleTargetAttack<TAttribute> : IAttack
		where TAttribute : StatsModule.Attribute // можно ли сделать это не обязательным пунктом? имею ввиду <TAttribute> или лучше сделать отдельным классом?
	{
		public readonly TakeDamageController _takeDamageController;
		public List<Damage> damages { get; } // разделить ли атаки у которых лишь один инстанс урона от атак с несколькими?
		public Character initiator { get; }
		public Character target { get; }

		public SingleTargetAttack(
			TakeDamageController takeDamageController,
			List<Damage> damages,
			Character initiator,
			Character target)
		{
			_takeDamageController = takeDamageController;
			this.damages = damages;
			this.initiator = initiator;
			this.target = target;
		}

		// атака с одним кубиком урона
		// атака с несколькими кубами

		// атака с проверкой атрибута
		// атака с наложением эффекта
	}
}