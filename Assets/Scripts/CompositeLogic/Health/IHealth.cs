namespace CompositeLogic.Health
{
	public interface IHealth
	{
		public int CurrentValue { get; }
		public int MaxValue { get; }
		public bool IsAlive { get; }
		
		void TakeDamage(int value);
	}
}