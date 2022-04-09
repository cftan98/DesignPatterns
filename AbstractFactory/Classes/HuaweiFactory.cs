using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class HuaweiFactory : IProductFactory
    {
        public ICellPhone GetPhone()
        {
            return new HuaweiCellPhone();
        }

        public IRouter GetRouter()
        {
            return new HuaweiRouter();
        }
    }
}
