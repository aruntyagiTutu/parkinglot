namespace ParkingLotSystem
{
    public interface IObserver
    {
        void Update(string message);
    }

    public class DisplayBoard : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[DisplayBoard] {message}");
        }
    }

    public class NotificationService : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[NotificationService] Sending Alert: {message}");
        }
    }


}