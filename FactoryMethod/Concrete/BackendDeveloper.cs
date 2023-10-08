using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

internal record BackendDeveloper : Developer
{
    public BackendDeveloper(string name) : base(name)
    {
    }

    public override Part Work() => new BackendPart();
}
