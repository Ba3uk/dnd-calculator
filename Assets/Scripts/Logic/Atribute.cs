using UnityEngine;

namespace Logic
{
	public abstract class Atribute
	{
		public int Value { get; set; }
		public int SaveModifier { get; set; }
		public int CheckModifier { get; set; }

		public Atribute(int Value)
		{
			this.Value = Value;
			SaveModifier = (Value - 10) / 2;
			SaveModifier = CheckModifier;
		}

		public int CheckRoll(int MaxRoll)
		{
			return Random.Range(1, MaxRoll) + CheckModifier;
		}

		public int SaveRoll(int MaxRoll)
		{
			return Random.Range(1, MaxRoll) + SaveModifier;
		}
	}
}