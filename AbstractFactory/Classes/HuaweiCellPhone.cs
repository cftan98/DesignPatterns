using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class HuaweiCellPhone : ICellPhone
    {
        public void Call()
        {
            Console.WriteLine("Start calling using Huawei");
        }
    }
}
