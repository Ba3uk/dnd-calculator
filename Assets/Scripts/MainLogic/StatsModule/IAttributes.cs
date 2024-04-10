using Assets.Scripts.MainLogic.StatsModule.AttributesList;

namespace Assets.Scripts.MainLogic.StatsModule
{
    public interface IAttributes
    {
        public Strength strength { get; }
        public Dexterity dexterity { get; }
        public Constitution constitution { get;}
        public Intelegence intelegence { get;}
        public Charisma charisma { get; }
        public Wisdom wisdom { get; }

        
    }
}
