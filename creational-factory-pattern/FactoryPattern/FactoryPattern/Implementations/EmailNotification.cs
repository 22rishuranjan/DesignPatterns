using FactoryPattern.Interfaces;

namespace FactoryPattern.Implementations
{
    public class EmailNotification :INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
