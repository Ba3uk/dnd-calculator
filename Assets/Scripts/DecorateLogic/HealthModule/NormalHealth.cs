namespace DecorateLogic.HealthModule
{
	public class NormalHealth : IHealth
	{
		public int CurrentValue { get; private set; }
		public int MaxValue { get; private set; }
		public bool IsAlive => CurrentValue > 0;

		public NormalHealth(int CurrentValue, int MaxValue)
		{
			this.CurrentValue = CurrentValue;
			this.MaxValue = MaxValue;
		}

		public void TakeDamage(int value)
		{
			CurrentValue -= value;
		}
	}
}