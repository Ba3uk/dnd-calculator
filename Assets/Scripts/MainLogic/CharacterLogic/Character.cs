namespace Assets.Scripts.MainLogic
{
    public class Character
    {
        public int id { get; private set; }
        public string name { get; set; }

        public Character(string name)
        {
            this.name = name;
            id++;
        }
    }
}
