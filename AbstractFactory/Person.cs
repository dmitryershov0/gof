namespace AbstractFactory
{
    public record Person
    {
        public string Name { get; set; }

        public PersonType PersonType { get; set; }

        public Person(string name, PersonType type)
        {
            Name = name;
            PersonType = type;
        }
    }
}
