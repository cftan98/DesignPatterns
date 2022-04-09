namespace AbstractFactory.Interfaces
{
    internal interface IProductFactory
    {
        ICellPhone GetPhone();
        IRouter GetRouter();
    }
}
