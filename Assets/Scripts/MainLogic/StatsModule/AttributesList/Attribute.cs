using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic.StatsModule
{
    public abstract class Attribute
    {
        public int value { get; }
        public int saveModifier { get; }
        public int checkModifier { get;  }

        public Attribute(int value) 
        {
            this.value = value;
            saveModifier = (value - 10) / 2;
            checkModifier = saveModifier; // нормально ли? это базовый конструктор, без учета баффов статов и тд, то есть стартовые характеристики для каждого объекта Attribute
        }

        
    }
}
