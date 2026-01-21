using Builder.FluentBuilder;
using Builder.ImmutableObjectBuilder;

var email = new EmailMessageBuilder()
    .To("user@email.com")
    .Subject("Welcome")
    .Body("Hello Imran")
    .From("Mike@email.com")
    .AsHtml()
    .Build();

Console.WriteLine(email);


Console.WriteLine("--------------------------------------------------");

var order = new Order.Builder("ORD-101", 1500)
    .MarkAsPaid()
    .AddNotes("Priority order")
    .Build();

Console.WriteLine(order);

Console.ReadLine();


