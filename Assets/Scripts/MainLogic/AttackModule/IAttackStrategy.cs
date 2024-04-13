using Assets.Scripts.MainLogic.AttackModule;
using System;
using System.Collections.Generic;

namespace MainLogic.AttackModule
{
	public interface IAttackStrategy
	{
		IReadOnlyList<Type> AvailableAttackTypes { get; }
		void Attack(IAttack attack);
	}

	public class AttackStrategyComposite
	{
		private Dictionary<Type, IAttackStrategy> _attackStrategies;

		public AttackStrategyComposite(List<IAttackStrategy> AttackStrategies)
		{
			_attackStrategies = new Dictionary<Type, IAttackStrategy>(AttackStrategies.Count);
			foreach (var attackStrategy in AttackStrategies)
			{
				foreach (var type in attackStrategy.AvailableAttackTypes)
				{
					_attackStrategies.Add(type, attackStrategy);
				}
			}
		}

		public void Attack(IAttack Attack)
		{
			var strategy = AttackStrategy(Attack);
			strategy.Attack(Attack);
		}

		private IAttackStrategy AttackStrategy(IAttack Attack)
		{
			var attackType = Attack.GetType();
			foreach (var pair in _attackStrategies)
			{
				if (pair.Key == attackType)
				{
					return pair.Value;
				}
			}

			throw new Exception($"Can't find Attack strategy with type = '{attackType}'");
		}
	}

	public class AttackStrategyWithOutConditions : IAttackStrategy
	{
		private TakeDamageController _takeDamageController;
		public IReadOnlyList<Type> AvailableAttackTypes { get; }

		public AttackStrategyWithOutConditions(TakeDamageController TakeDamageController)
		{
			_takeDamageController = TakeDamageController;
		}

		public void Attack(IAttack attack)
		{
			attack.AttackAction();
		}
	}
}