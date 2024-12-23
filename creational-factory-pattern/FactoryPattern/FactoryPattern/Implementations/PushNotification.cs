using FactoryPattern.Interfaces;

namespace FactoryPattern.Implementations
{
    public class PushNotification :INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
