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

    }

}