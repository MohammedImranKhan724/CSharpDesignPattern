using Factory.FactoryExampleOne;
using System;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent with message: {message}");
    }
}