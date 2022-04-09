using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class AppleRouter : IRouter
    {
        public void Route()
        {
            Console.WriteLine("Routing Apple");
        }
    }
}
