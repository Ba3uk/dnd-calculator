namespace OldLogic
{
	public class MagicalAttack : IAttack
	{
		public Damage Damage { get; set; }
		public Character Target { get; set; }

		public Atribute Save { get; set; }

		public void AttackAction() { }
	}
}