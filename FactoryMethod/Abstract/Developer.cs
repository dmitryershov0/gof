namespace FactoryMethod.Abstract;

internal abstract record Developer
{
    public string Name { get; set; }

    public Developer(string name) => Name = name;

    public abstract Part Work();
}
