using Factory.Interfaces;

namespace Factory
{
    public interface ICarFactory
    {
        public ICar GetToyota( );
        public ICar GetHonda( );
    }
}
