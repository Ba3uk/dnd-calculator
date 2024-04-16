using CompositeLogic;

namespace DecorateLogic.HealthModule
{
    public class HealthProvider : GenericProvider<int, IHealth> { }

	public class InventoryProvider : GenericProvider<int, IInventory> { }
}