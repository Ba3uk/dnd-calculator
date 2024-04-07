namespace Logic
{
	public interface IAttack // как лучше добавить "инвентарь" атак персонажу? List<IAttack>?
	{
		public Character Target { get; set; }
		public Atribute Save { get; set; }
		public void AttackAction();
	}
}