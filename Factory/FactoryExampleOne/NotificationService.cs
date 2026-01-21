namespace Factory.FactoryExampleOne
{
    public class NotificationService
    {
        public void Send(string type, string message)
        {
            INotification notification = SimpleNotificationFactory.Create(type);

            notification.Send(message);
        }
    }
}