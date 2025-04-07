namespace DependencyInjection.Services;

public class TestInterface
{
    public void SendNotification(string target, string message)
    {
        //SmsNotificationSercice service = new SmsNotificationSercice();
        //EmailNotificationService service = new EmailNotificationService();

        
        //INotificationService service = new EmailNotificationService();
        INotificationService service = new SmsNotificationSercice();

        service.SendMessage(target, message);
        
        //service.SendOTP();
    }


    //Dpendency Container 

    //Dpendency Injection
    //تزریق وابستگی
    //Mock service - testing
    public void SendNotificationWithDI(
        string target, string message, INotificationService service)
    {
        service.SendMessage(target, message);
    }




}
