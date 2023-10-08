using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete
{
    internal record BackendPart : Part
    {
        public BackendPart()
        {
            Console.WriteLine("Make backend part");
        }
    }
}
