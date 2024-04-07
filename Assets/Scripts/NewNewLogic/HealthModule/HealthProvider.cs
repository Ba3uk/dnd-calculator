using NewLogic;

namespace NewNewLogic.HealthModule
{
	public class HealthProvider : GenericProvider<int, IHealth> { }

	public class InventoryProvider : GenericProvider<int, IInventory> { }
}