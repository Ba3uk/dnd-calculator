namespace Logic
{
	public class DamageOverTimeCondition : ICondition
	{
		public string Title { get; set; }
		public string Description { get; set; }

		public DamageOverTimeCondition(string title, string description)
		{
			Title = title;
			Description = description;
		}

		public void TakeEffect(Character Target) // месиво начинается какое-то блин надо разбираться как правильно сделать урон
		{
			Target.TakeDamage(UnityEngine.Random.Range(1, 4));
		}
	}
}