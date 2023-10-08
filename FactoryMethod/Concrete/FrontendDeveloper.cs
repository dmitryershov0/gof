using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

internal record FrontendDeveloper : Developer
{
    public FrontendDeveloper(string name) : base(name)
    {
    }

    public override Part Work() => new FrontendPart();
}
