namespace Prototype.ShallowCopy;

public class Person : IPrototype<Person>
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Person Clone()
    {
        return (Person)this.MemberwiseClone(); // Shallow copy
    }

    public override string ToString()
    {
        return $"Name: {Name}, City: {Address.City}";
    }
}