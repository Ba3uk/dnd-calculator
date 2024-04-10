using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic
{
    public enum DamageType
    {
        None = 0,
        Piercing = 1,
        Slashing = 2,
        Bludgeoning = 3,
        Acid = 4,
        Cold = 5,
        Fire = 6,
        Force = 7,
        Lightning = 8,
        Necrotic = 9,
        Poison = 10,
        Psychic = 11,
        Radiant = 12,
        Thunder = 13
    }

    public class Damage
    {
        public DamageType type { get; }
        public Dice dice { get; }
        public int value { get; }

        public Damage(DamageType type, Dice dice)
        {
            this.type = type;
            this.dice = dice;
            value = dice.Roll();
        }
    }
}
