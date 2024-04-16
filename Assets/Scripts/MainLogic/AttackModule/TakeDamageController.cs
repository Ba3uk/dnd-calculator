using Assets.Scripts.MainLogic.AttackLogic;
using Assets.Scripts.MainLogic.HealthModule;
using System.Collections.Generic;

namespace Assets.Scripts.MainLogic.AttackModule
{
    public class TakeDamageController : ITakeDamage // а можно ли его сделать статичным? 
    {
        public readonly HealthProvider _healthProvider;
        public TakeDamageController(HealthProvider healthProvider)
        {
            _healthProvider = healthProvider;
        }

        public void TakeDamage(Character target, Damage damage)
        {
            if(!_healthProvider.TryGetValue(target.id, out IHealth health))
            {
                return;
            }

            health.TakeDamage(damage);
        }

        public void TakeGroupDamage(List<Character> targets, Damage damage)
        {
            foreach(Character target in targets)
            {
                TakeDamage(target, damage);
            }
        }
    }
}
