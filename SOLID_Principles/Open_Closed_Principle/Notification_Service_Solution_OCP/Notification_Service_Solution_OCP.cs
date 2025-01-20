using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NotificationService
{
    private readonly INotification _INotificationService;
    public NotificationService(INotification Inotification) => _INotificationService = Inotification;
    public void Send(string To, string message) => _INotificationService.Send(To, message);
    
}

public interface INotification
{
    void Send(string To, string message);
}
public class EmailService : INotification
{
    public void Send(string To, string message) =>  Console.WriteLine($"Send Email to {To}: {message}");
        
}

public class SMSService : INotification
{
    public void Send(string To, string message) =>  Console.WriteLine($"Send SMS to {To}: {message}");
    
}

public class FaxService : INotification
{
    public void Send(string To, string message) => Console.WriteLine($"Send Fax to {To}: {message}");
    
}

public class WhatsappService : INotification
{
    public void Send(string To, string message) => Console.WriteLine($"Send Whatsapp to {To}: {message}");

}

public class LinkedinService : INotification
{
    public void Send(string To, string message) => Console.WriteLine($"Send Linkedin to {To}: {message}");

}



class Program
{
    static void Main()
    {
        NotificationService notificationService = new NotificationService(new EmailService());
        notificationService.Send("john@example.fr", "Welcome to our service");

        notificationService = new NotificationService(new SMSService());
        notificationService.Send("212645576859", "Your OTP code is 2345");

        notificationService = new NotificationService(new FaxService());
        notificationService.Send("212-645-576-859", "Check this important document");

        notificationService = new NotificationService(new WhatsappService());
        notificationService.Send("212-645-576-859", "Check this important video");

        notificationService = new NotificationService(new LinkedinService());
        notificationService.Send("212-645-576-859", "Check this important course");

        Console.ReadLine();

    }
}

