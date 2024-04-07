namespace Logic
{
	public class Equipment : Item // как реализовать добавление статов персонажу при надевании экипировки?
	{
		public bool isEquipped { get; set; }

		public Equipment(
			int Id,
			string Title,
			bool isEquipped,
			float Weight,
			string Description,
			int Cost)
			: base(Id,
				Title,
				Weight,
				Description,
				Cost)
		{
			this.Id = Id;
			this.Title = Title;
			this.Weight = Weight;
			this.Description = Description;
			this.Cost = Cost;
			this.isEquipped = isEquipped;
		}

		public void Equip(Character Character)
		{
			isEquipped = true;
		}

		public void UnEquip(Character Character)
		{
			isEquipped = false;
		}
	}
}