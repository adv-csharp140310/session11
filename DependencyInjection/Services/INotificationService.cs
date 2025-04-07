namespace DependencyInjection.Services;

public interface INotificationService
{
    void SendMessage(string target, string message);
}
