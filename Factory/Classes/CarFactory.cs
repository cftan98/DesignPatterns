using Factory.Interfaces;

namespace Factory.Classes
{
    public class CarFactory : ICarFactory
    {
        public ICar GetHonda()
        {
            return new Honda();
        }

        public ICar GetToyota()
        {
            return new Toyota();
        }
    }
}
