namespace Logic
{
    public interface
		ICondition // как реализовывать подобные штуки? статус-эффекты и другие дебаффы (возможно пофиксится само-собой когда у меня появится походовая система боя)
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public void TakeEffect(Character Target);
	}
}