namespace Unit2.Game
{
    class Director{
        static int currCard;
        static int oldCard;
        static int totalScore = 300;
        static string userChoice;
        public void playGame(){
            Card CardDraw = new Card();
            currCard = CardDraw.callCard();
            Console.WriteLine($"The card is: {currCard}");
            Console.WriteLine("Higher or lower? [h/l] ");
            string userInput = Console.ReadLine();
            if (userInput == "h"){
                oldCard = currCard;
                currCard = CardDraw.callCard();
                compareCards(currCard, oldCard, userInput);
                Console.WriteLine($"Next card was: {currCard}");
                Console.WriteLine($"Your score is: {totalScore}");
                Continue();
            } else if (userInput == "l"){
                oldCard = currCard;
                currCard = CardDraw.callCard();
                compareCards(currCard, oldCard, userInput);
                Console.WriteLine($"Next card was: {currCard}");
                Console.WriteLine($"Your score is: {totalScore}");
                Continue();
            }
        }
        public void Continue(){
            Console.WriteLine("Play again? [y/n] ");
            string userContinue = Console.ReadLine();
            if (userContinue == "y"){
                playGame();
            }else{

            }
        }

        public void compareCards(int curr, int old, string choice){
            if (choice == "l"){
                if (curr < old){
                    totalScore = totalScore + 100;

                }else{
                    totalScore = totalScore - 75;
                }
            } else if (choice == "h"){
                if (curr > old){
                    totalScore += 100;
                } else {
                    totalScore = totalScore - 75;
                }
            }
        }
    }
}