using System.Diagnostics;

namespace DependencyInjection.Services;

public class EmailNotificationService : INotificationService
{
    public void SendMessage(string target, string message)
    {        
        Debug.WriteLine($"Sending EMAIL notification to {target} : {message}");
    }

    public void Attachemnt() { }
    public void Xyz() { }

}