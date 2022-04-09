using AbstractFactory.Interfaces;
namespace AbstractFactory.Classes
{
    internal class AppleFactory : IProductFactory
    {
        public ICellPhone GetPhone()
        {
            return new AppleCellPhone();
        }

        public IRouter GetRouter()
        {
            return new AppleRouter();
        }
    }
}
