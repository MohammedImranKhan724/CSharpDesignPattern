namespace Prototype.DeepCopy
{
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }

        public Address Address { get; set; }
        public Person Clone()
        {
            return new Person
            {
                Name = this.Name,
                Address = new Address
                {
                    City = this.Address.City
                }
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}, City: {Address.City}";
        }
    }
}
