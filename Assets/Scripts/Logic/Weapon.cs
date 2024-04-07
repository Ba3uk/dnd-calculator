namespace Logic
{
	public class Weapon : Equipment // палка для стат, не должна сама уметь атаковать, используется для передачи параметров в martialattack
	{
		public Damage Damage { get; set; } // что делать если мне нужно несколько кубиков за каждую атаку? делать массив уронов и складвыать значения?

		// сделать отдельный класс для таких атак(мультимартиалаттак)? чтобы не нагружать память лишними массивами с одним элементом? 
		// сделать доп. конструктор с реализацией первого комментария?
		public Weapon(
			int Id,
			string Title,
			bool isEquipped,
			Damage Damage,
			float Weight,
			string Description,
			int Cost)
			: base(Id,
				Title,
				isEquipped,
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
			this.Damage = Damage;
		}
	}
}