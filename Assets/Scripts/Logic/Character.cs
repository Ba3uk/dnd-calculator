using Logic.Atributs;
using System.Collections.Generic;
using UnityEngine;

namespace Logic
{
	public abstract class Character
	{
		public int Health
		{
			get => health;
			set
			{
				if (value < 0)
					health = 0;
				else
					health = value;
			}
		}

		public int MaxHealth { get; set; }
		public Abilities Abilities { get; set; }

		public string
			Title { get; set; } 

		public List<ICondition> Conditions { get; set; }

		public abstract List<Item> Inventory { get; set; } // переделать под класс (scriptable object)?
		private int health;

		public Character(string Title, Abilities Abilities, int ClassHealthMultiplier)
		{
			this.Title = Title;
			this.Abilities = Abilities;
			MaxHealth = 10 + (Abilities.Constitution.CheckModifier * ClassHealthMultiplier);
			Health = MaxHealth;
		}

		public abstract void AttackRoll(int Dice, Atribute Atribute, IAttack Attack); 
		public abstract void SaveRoll(int Dice, int Difficulty, Atribute Atribute);
		public abstract void DamageRoll(IAttack Attack);

		public virtual void
			TakeDamage(int Damage) 
		{
			Health -= Damage;

			Debug.Log($"{Title}'s health: " + Health);

			if (Health <= 0)
				Death();
		}

		private void Death()
		{
			Debug.Log($"{Title} is dead");
		}
	}
}