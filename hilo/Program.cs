using Unit2.Game;
namespace Unit2{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Director Person1 = new Director("John");
            // Director Person2 = new Director("Madz");
            // Card Card1 = new Card();
            // Person1.Greeting();
            // Console.WriteLine(Card1.callCard());
            Director Person1 = new Director();
            Person1.playGame();

        }
    }

}