
using FactoryPattern.Implementations;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factory
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type.")
            };
        }
    }
}
