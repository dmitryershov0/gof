// See https://aka.ms/new-console-template for more information
using FactoryMethod.Abstract;
using FactoryMethod.Concrete;

Developer backendDeveloper = new BackendDeveloper("Dmitry");
Developer frontendDeveloper = new FrontendDeveloper("Ivan");
backendDeveloper.Work();
frontendDeveloper.Work();

Console.ReadLine();
