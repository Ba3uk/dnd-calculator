using System.Collections.Generic;
using UnityEngine;

namespace Logic
{
	public enum DamageType
	{
		None = 0,
		Slashing = 1,
		Piercing = 2,
		Bludgeoning = 3,
		Fire = 4,
		Cold = 5,
		Acid = 6,
		Poison = 7,
		Lightning = 8,
		Thunder = 9,
		Radiant = 10,
		Necrotic = 11,
		Psychic = 12,
		Force = 13
	}

	public class Damage
	{
		public DamageType DamageType { get; }
		public int Value { get; }
		public int MaxRoll { get; }

		public Damage(DamageType DamageType, int Value)
		{
			this.DamageType = DamageType;
			this.Value = Value;
		}
	}

	public interface IMaxRoll
	{
		int CalculateRoll();
	}

	class DiceMaxRoll : IMaxRoll
	{
		private List<Dice> _dices;

		public DiceMaxRoll(List<Dice> dices)
		{
			_dices = dices;
		}

		public int CalculateRoll()
		{
			var result = 0;
			foreach (var dice in _dices)
			{
				result += dice.Roll();
			}

			return result;
		}
	}

	class SingleDiceMaxRoll : IMaxRoll
	{
		private Dice _dice;

		public SingleDiceMaxRoll(Dice Dice)
		{
			_dice = Dice;
		}

		public int CalculateRoll()
		{
			return _dice.Roll();
		}
	}

	public class Dice
	{
		public int DiceFacesCount { get; }

		public Dice(int DiceFacesCount)
		{
			this.DiceFacesCount = DiceFacesCount;
		}

		public int Roll()
		{
			return Random.Range(0, DiceFacesCount);
		}
	}

	/*public class DiceProvider
	{
		private Dictionary<int, Dice> _diceMap;

		public Dice GetDice(int DiceFacesCount)
		{
			if (_diceMap.TryGetValue(DiceFacesCount, out var dice))
			{
				return dice;
			}

			var newDice = new Dice(DiceFacesCount);
			_diceMap.Add(DiceFacesCount, newDice);
			return newDice;
		}
	}*/
}