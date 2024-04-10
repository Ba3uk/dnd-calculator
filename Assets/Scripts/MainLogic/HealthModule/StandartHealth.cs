using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MainLogic.HealthModule
{
    public class StandartHealth
    {
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public bool isAlive => currentHealth > 0;

        public void TakeDamage(Damage damage)
        {
            Debug.Log("I took damage: " + damage.value);
        }
        //public void Heal(int healingValue); void на будущее, скорее всего будет испльзоваться
    }
}
