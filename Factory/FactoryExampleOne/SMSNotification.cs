using Factory.FactoryExampleOne;
using System;

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS sent with message: {message}");
    }
}
