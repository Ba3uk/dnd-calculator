using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic
{
    public interface IHealth
    {
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public bool isAlive { get; set; }

        public void TakeDamage(Damage damage);
        //public void Heal(int healingValue); void на будущее, скорее всего будет испльзоваться
        public void Death();

    }
}
