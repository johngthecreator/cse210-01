namespace Unit2.Game{
    public class Card{
        public int randomNum;

        public int callCard(){
            Random rnd = new Random();
            randomNum = rnd.Next(1,14);
            return randomNum;
        }


    }
}