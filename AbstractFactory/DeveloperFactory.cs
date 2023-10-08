using FactoryMethod.Abstract;
using FactoryMethod.Concrete;

namespace AbstractFactory;

public class DeveloperFactory
{
    public Developer GetDeveloper(Person person)
    {
        switch (person.PersonType)
        {
            case PersonType.Backend: return new BackendDeveloper(person.Name);
            case PersonType.Frontend: return new FrontendDeveloper(person.Name);
            default: throw new NotImplementedException();
        }
    }
}
