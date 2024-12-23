using FactoryPattern.Interfaces;

namespace FactoryPattern.Implementations
{
    public class SmsNotification :INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}
