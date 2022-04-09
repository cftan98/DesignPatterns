using Factory.Interfaces;

namespace Factory.Classes
{
    public class Toyota : ICar
    {
        public void Start()
        {
            Console.WriteLine("Starting Toyota");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Toyota");
        }
    }
}
