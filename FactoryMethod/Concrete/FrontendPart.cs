using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete
{
    internal record FrontendPart : Part
    {
        public FrontendPart()
        {
            Console.WriteLine("Make frontend part");
        }
    }
}
