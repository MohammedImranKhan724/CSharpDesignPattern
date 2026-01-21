using System;

namespace Factory.FactoryExampleOne
{
    public class SimpleNotificationFactory
    {
        public static INotification Create(string type)
        {
            return type switch
            {
                "Email" => new EmailNotification(),
                "SMS" => new SMSNotification(),
                "Push" => new PushNotification(),

                // in Future we can add more notification types here like whatsapp, slack etc.
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}
