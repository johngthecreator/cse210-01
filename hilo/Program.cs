using Unit2.Game;
namespace Unit2{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Director Person1 = new Director("John");
            Director Person2 = new Director("Madz");
            Person1.Greeting();

        }
    }

}