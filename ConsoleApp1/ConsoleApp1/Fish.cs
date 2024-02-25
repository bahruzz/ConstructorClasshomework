

namespace ConsoleApp1
{
    internal class Fish:Animal
    {
        public string color;

        public Fish():base("JustConstructor")      
       
        {
            Console.WriteLine("Fish Constructor");
        }

    }
}
