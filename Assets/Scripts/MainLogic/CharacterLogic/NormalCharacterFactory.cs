using Assets.Scripts.MainLogic.HealthModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic.CharacterLogic
{
    public class NormalCharacterFactory
    {
        public Character Create(string name, int currentValue, int maxValue)
        {
            IHealth health = new StandartHealth();
        }
    }
}
