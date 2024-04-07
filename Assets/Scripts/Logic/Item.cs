

//[CreateAssetMenu(fileName ="ItemData", menuName ="Inventory/Items")] : ScriptableObject
namespace Logic
{
	public class Item
	{
		public string Title { get; set; }
		public int Id { get; set; }
		public float Weight { get; set; }
		public string Description { get; set; }
		public int Cost { get; set; }

		public Item(
			int Id,
			string Title,
			float Weight,
			string Description,
			int Cost)
		{
			this.Id = Id;
			this.Title = Title;
			this.Weight = Weight;
			this.Description = Description;
			this.Cost = Cost;
		}
	}
}