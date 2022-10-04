namespace Unit2.Game
{
    class Director{

        bool isPlaying = true;
        public int score = 300;
        public int currentCard;

        public string guess;
        public Director(){
           
        }

        public void startGame(){
            while(isPlaying){
                selectCard();
                getGuess();
                checkGuess();

            }
        }
        public void selectCard(){
            
        }

        public void getGuess(){
            Console.WriteLine("The card is: " + currentCard);
            Console.WriteLine("Higher or Lower? [h/l] ");
            guess = Console.ReadLine();
        }
        public void checkGuess(){
            
        }

    }

}