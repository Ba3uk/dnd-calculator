using UnityEngine;

namespace Assets.Scripts.MainLogic.HealthModule
{
    public class StandartHealth : IHealth
    {
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public bool isAlive => currentHealth > 0; // как-то придумать и решать нада



        public void TakeDamage(Damage damage)
        {
            Debug.Log("I took damage: " + damage.value);
        }
        //public void Heal(int healingValue); void на будущее, скорее всего будет испльзоваться
    }
}
