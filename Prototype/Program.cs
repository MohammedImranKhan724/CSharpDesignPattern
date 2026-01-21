//using Prototype.ShallowCopy;

//// Shallow Copy Prototype Pattern
//var person1 = new Person
//{
//    Name = "Imran",
//    Address = new Address { City = "Delhi" }
//};

//Console.WriteLine("Before clone");
//Console.WriteLine(person1.ToString());

//Console.WriteLine("---------------------");

//var person2 = person1.Clone();

//// Modify cloned object
//person2.Address.City = "Mumbai";

//// Output
//Console.WriteLine("Person1 City:");
//Console.WriteLine(person1.Address.City);

//Console.WriteLine("---------------------");

//Console.WriteLine("Person1 Details:");
//Console.WriteLine(person1.ToString());

//Console.WriteLine("---------------------");

//Console.WriteLine("Person2 Details:");
//Console.WriteLine(person2.ToString());

//Console.ReadLine();

using Prototype.DeepCopy;

// Deep Copy Prototype Pattern
var person1 = new Person
{
    Name = "Imran",
    Address = new Address { City = "Delhi" }
};

Console.WriteLine("Before clone");
Console.WriteLine(person1.ToString());

Console.WriteLine("---------------------");

var person2 = person1.Clone();

// Modify cloned object
person2.Address.City = "Mumbai";

// Output
Console.WriteLine("Person1 City:");
Console.WriteLine(person1.Address.City);

Console.WriteLine("---------------------");

Console.WriteLine("Person1 Details:");
Console.WriteLine(person1.ToString());

Console.WriteLine("---------------------");

Console.WriteLine("Person2 Details:");
Console.WriteLine(person2.ToString());

Console.ReadLine();
