namespace DependencyInjection.Services;

public class SmsNotificationSercice : INotificationService
{
    public void SendMessage(string target, string message)
    {
        Console.WriteLine($"Sending SMS notification to {target} : {message}");
    }
    
    public void SendOTP()
    {
        //
    }
}
