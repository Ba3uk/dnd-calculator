using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic.AttackModule
{
    public interface IAttack
    {
        public List<Damage> damages { get; }
        public Character initiator { get; }
        public Character target { get; }
        public void AttackAction();
    }
}
