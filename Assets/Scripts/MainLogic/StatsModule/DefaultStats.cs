using Assets.Scripts.MainLogic.StatsModule.AttributesList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic.StatsModule
{
    public class DefaultStats : IAttributes
    {
        public Strength strength { get; }

        public Dexterity dexterity { get; }

        public Constitution constitution { get; }

        public Intelegence intelegence { get; }

        public Charisma charisma { get; }

        public Wisdom wisdom { get; }

        public DefaultStats(Strength strength, Dexterity dexterity, Constitution constitution, Intelegence intelegence, Charisma charisma, Wisdom wisdom)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelegence = intelegence;
            this.charisma = charisma;
            this.wisdom = wisdom;
        }
    }
}
