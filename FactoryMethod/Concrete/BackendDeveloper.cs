using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

public record BackendDeveloper : Developer
{
    public BackendDeveloper(string name) : base(name)
    {
    }

    public override Part Work() => new BackendPart();
}
