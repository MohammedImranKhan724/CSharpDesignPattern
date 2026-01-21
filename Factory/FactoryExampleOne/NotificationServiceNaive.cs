namespace Factory.FactoryExampleOne;

public class NotificationServiceNaive
{
    public void Send(string type, string message)
    {
        if (type == "Email")
        {
            new EmailNotification().Send(message);
        }
        else if (type == "SMS")
        {
            new SMSNotification().Send(message);
        }
        else if (type == "Push")
        {
            new PushNotification().Send(message);
        }
    }
}