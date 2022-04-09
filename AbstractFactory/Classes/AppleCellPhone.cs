using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class AppleCellPhone : ICellPhone
    {
        public void Call()
        {
            Console.WriteLine("Start calling using Apple");
        }
    }
}
