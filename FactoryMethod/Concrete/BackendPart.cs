using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete
{
    public record BackendPart : Part
    {
        public BackendPart()
        {
            Console.WriteLine("Make backend part");
        }
    }
}
