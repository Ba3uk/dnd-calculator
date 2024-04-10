using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic.AttackLogic
{
    public interface ITakeDamage
    {
        public void TakeDamage(Character character, Damage damage);
        public void TakeGroupDamage(List<Character> characters, Damage damage);
    }
}
