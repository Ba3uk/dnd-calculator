using System.Collections.Generic;
using System.Linq;

namespace Logic.Atributs
{
    public class Abilities
	{
		public Strength Strength { get; set; }
		public Dexterity Dexterity { get; set; }
		public Constitution Constitution { get; set; }
		public Intelegence Intelegence { get; set; }
		public Wisdom Wisdom { get; set; }
		public Charisma Charisma { get; set; }

		public HashSet<Atribute> Atributess = new();

		public int
			ArmorClass
		{
			get;
			set;
		} // сделать классом? этот стат будет зависеть от нескольких показателей // засунуть логику класса брони в abilities? он зависит от них в целом...

		public Dictionary<DamageType, float> Resistances { get; set; }

		public Abilities(List<Atribute> Atributess)
		{
			this.Atributess = Atributess.ToHashSet();
		}

		public bool TryGetAtribute<TAtribute>(out TAtribute Atribute)
			where TAtribute : Atribute
		{
			Atribute = null;

			foreach (var atribute in Atributess)
			{
				if (atribute is TAtribute result)
				{
					Atribute = result;
					break;
				}
			}

			return Atribute != null;
		}

		public Abilities(
			Strength Strength,
			Dexterity Dexterity,
			Constitution Constitution,
			Intelegence Intelegence,
			Wisdom Wisdom,
			Charisma Charisma)
		{
			this.Strength = Strength;
			this.Dexterity = Dexterity;
			this.Constitution = Constitution;
			this.Intelegence = Intelegence;
			this.Wisdom = Wisdom;
			this.Charisma = Charisma;
			ArmorClass = 10 + Dexterity.CheckModifier;
			Resistances = new Dictionary<DamageType, float>
			{
				{DamageType.Slashing, 1},
				{DamageType.Piercing, 1},
				{DamageType.Bludgeoning, 1},
				{DamageType.Fire, 1},
				{DamageType.Cold, 1},
				{DamageType.Acid, 1},
				{DamageType.Poison, 1},
				{DamageType.Lightning, 1},
				{DamageType.Thunder, 1},
				{DamageType.Radiant, 1},
				{DamageType.Necrotic, 1},
				{DamageType.Psychic, 1},
				{DamageType.Force, 1}
			};
		}
	}
}