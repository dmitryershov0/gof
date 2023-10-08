// See https://aka.ms/new-console-template for more information
using AbstractFactory;

var persons = new Person[]
{
    new Person("Dmitry", PersonType.Backend),
    new Person("Ivan", PersonType.Frontend)
};

var factory = new DeveloperFactory();

foreach (var person in persons)
{
    var developer = factory.GetDeveloper(person);
    developer?.Work();
}
