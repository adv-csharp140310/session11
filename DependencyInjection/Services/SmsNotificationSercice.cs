using System.Diagnostics;

namespace DependencyInjection.Services;

public class SmsNotificationSercice : INotificationService
{
    public void SendMessage(string target, string message)
    {
        Debug.WriteLine($"Sending SMS notification to {target} : {message}");
    }
    
    public void SendOTP()
    {
        //
    }
}
