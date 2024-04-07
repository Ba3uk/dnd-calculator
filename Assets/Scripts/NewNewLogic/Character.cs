namespace NewNewLogic
{
	public class Character
	{
		public int ID;
		public string Name;
		public string SkinId;

		public Character(string Name, string SkinId, int ID)
		{
			this.Name = Name;
			this.SkinId = SkinId;
			this.ID = ID;
		}
	}
}