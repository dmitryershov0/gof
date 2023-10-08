using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete
{
    public record FrontendPart : Part
    {
        public FrontendPart()
        {
            Console.WriteLine("Make frontend part");
        }
    }
}
