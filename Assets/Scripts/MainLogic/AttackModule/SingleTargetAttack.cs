using System.Collections.Generic;

namespace Assets.Scripts.MainLogic.AttackModule
{
    public class SingleTargetAttack : IAttack
    {
        public readonly TakeDamageController _takeDamageController;
        public List<Damage> damages { get; } // разделить ли атаки у которых лишь один инстанс урона от атак с несколькими?
        public Character initiator { get; }
        public Character target { get; } // перенести как параметр attackAction?


        public SingleTargetAttack(TakeDamageController takeDamageController, List<Damage> damages, Character initiator, Character target)
        {
            _takeDamageController = takeDamageController;

            this.damages = damages;
            this.initiator = initiator;
            this.target = target;
        }
        public void AttackAction()
        {
            foreach (var damage in damages)
            {
                _takeDamageController.TakeDamage(target, damage);
            }
        }

		// атака с одним кубиком урона
		// атака с несколькими кубами

        // атака с одним кубиком урона
        // атака с несколькими кубами

        // атака с проверкой атрибута
        // атака с наложением эффекта
    }
}


