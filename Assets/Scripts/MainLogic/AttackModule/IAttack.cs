using System.Collections.Generic;

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
