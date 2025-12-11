namespace FacadeDP;

public class NotificationService : INotificationService
{
    public void send(string message)
    {
        Console.Write("Notification Message : " , message);
    }
}
