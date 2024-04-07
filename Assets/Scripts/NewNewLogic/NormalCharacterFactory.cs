using NewLogic;
using NewNewLogic.HealthModule;

namespace NewNewLogic
{
	public class NormalCharacterFactory
	{
		private static int lastId;
		private readonly HealthProvider _healthProvider;
		private readonly InventoryProvider _inventoryProvider;

		public NormalCharacterFactory(HealthProvider HealthProvider, InventoryProvider InventoryProvider)
		{
			_inventoryProvider = InventoryProvider;
			_healthProvider = HealthProvider;
		}

		public Character CreateCharacterWithHealth(int currentHealthValue, int maxValue)
		{
			lastId++;

			var result = new Character("Fred", "Fred_skin", lastId);
			_healthProvider.Register(result.ID, new NormalHealth(currentHealthValue, maxValue));
			_inventoryProvider.Register(result.ID, new Inventory());

			return result;
		}
	}
}