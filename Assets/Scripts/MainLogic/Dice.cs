namespace Assets.Scripts.MainLogic
{
    public class Dice
    {
        public int faces { get; set; }
        public int diceCount { get; set; }

        public Dice(int faces, int diceCount)
        {
            this.faces = faces;
            this.diceCount = diceCount;
        }
    
        public int Roll()
        {
            int result = 0;

            for(int i = 0; i < diceCount; i++)
            {
                result += UnityEngine.Random.Range(1, faces);
            }
            return result;
        }


        /*public int RollSingleDice(int dice) // метод для одного кубика
        {
            return UnityEngine.Random.Range(1,dice);
        }
        
        public int RollMultipleDieces(int[] dices) // метод для нескольких кубиков
        {
            int result = 0;
            foreach (int dice in dices)
            {
                result += RollSingleDice(dice);
            }
            return result;
        }*/
        
    }
}
