
using FactoryPattern.Factory;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Email notification
            INotification emailNotification = NotificationFactory.CreateNotification("email");
            emailNotification.Notify("This is an email notification.");

            // Create an SMS notification
            INotification smsNotification = NotificationFactory.CreateNotification("sms");
            smsNotification.Notify("This is an SMS notification.");

            // Create a Push notification
            INotification pushNotification = NotificationFactory.CreateNotification("push");
            pushNotification.Notify("This is a push notification.");

            Console.ReadKey();
        }
    }
}
