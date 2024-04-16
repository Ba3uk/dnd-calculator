namespace CompositeLogic.Health
{
    public class HealthWithShield : IHealth
	{
		public int CurrentValue { get; private set; }
		public int MaxValue { get; }
		public bool IsAlive => CurrentValue > 0;

		public HealthWithShield(int CurrentValue, int MaxValue)
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