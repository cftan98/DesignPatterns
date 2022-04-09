using Factory.Interfaces;

namespace Factory.Classes
{
    internal class Honda : ICar
    {
        public void Start()
        {
            Console.WriteLine("Starting Honda");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Honda");
        }
    }
}
