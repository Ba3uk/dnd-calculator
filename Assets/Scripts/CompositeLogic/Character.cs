using CompositeLogic.Health;

namespace CompositeLogic
{
	public class Character
	{
		public readonly IHealth Health;
		public readonly IInventory Inventory;

		public Character(IHealth Health, IInventory Inventory)
		{
			this.Health = Health;
			this.Inventory = Inventory;
		}
	}

	public class Test
	{
		public void test()
		{
			IHealth health = new NormalHealth(10, 20);
			IInventory Inventory = new Inventory();
			Character c = new Character(health, Inventory);
		}
	}

	public class NormalCharacterFactory
	{
		public Character Create(int currentHealthValue, int maxValue)
		{
			IHealth health = new NormalHealth(10, 20);
			IInventory Inventory = new Inventory();
			return new Character(health, Inventory);
		}
	}
}