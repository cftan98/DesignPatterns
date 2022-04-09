using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class HuaweiRouter : IRouter
    {
        public void Route()
        {
            Console.WriteLine("Routing Huawei");
        }
    }
}
