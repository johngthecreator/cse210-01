namespace Unit2.Game
{
    class Director{
        public string name;
        public Director(string theirName){
            name = theirName;
        }
        public void Greeting(){
            Console.WriteLine("Hello I am " + name);
        }
        static void Game()
    {
        Random rand = new Random();
        //List<int> firstList = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13};
        int points = 300;
        while (true)
        {
            
            int firstCard = rand.Next(1,14);
            int NextCard = rand.Next(1,14);

            if (firstCard != NextCard)
            {


            string Input = "";

            if (points != 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"The card is: {firstCard}");
                Console.WriteLine("Higher or lower? (h/l)");
                Input = Console.ReadLine();

                Console.WriteLine($"Next card was: {NextCard}");

            }
                if (Input == "h")
                {
                    if (NextCard > firstCard)
                    {
                        points = points + 100;
                        Console.WriteLine("You got it!");
                        Console.WriteLine($"You current score is {points}");
                        Console.WriteLine("");
                    }
                    else
                    {
                        points = points -75;
                        Console.WriteLine("That was not right!");
                        Console.WriteLine($"You current score is {points}");
                        Console.WriteLine("");
                    }
                }
                if (Input == "l")
                {
                    if (NextCard < firstCard)
                    {
                        points = points + 100;
                        Console.WriteLine("You got it!");
                        Console.WriteLine($"You current score is {points}");
                        Console.WriteLine("");
                    }
                    else
                    {
                        points = points - 75;
                        Console.WriteLine("That was not right!");
                        Console.WriteLine($"You current score is {points}");
                        Console.WriteLine("");
                        
                    }
                }
                
            //else
            //{
                Console.WriteLine("Do you want to play again? (y/n)");
                
            if (points <= 0)
            {
                Console.WriteLine($"Your lost all the points.");
                break;
            }
                else if (Console.ReadLine() != "y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thanks for playing!");
                    
                    break;
                }


            //}
            }

            
        }
    }
    static void Main(string[] args)
    {
        Game();
    }

    }
    

}