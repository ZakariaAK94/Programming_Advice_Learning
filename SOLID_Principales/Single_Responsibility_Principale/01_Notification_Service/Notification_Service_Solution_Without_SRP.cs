using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NotificationService
{

    public enum enNotificationType { Email, SMS, Fax };

    public void SendNotification(string To, string message, enNotificationType notificationType)
    {
        switch (notificationType)
        {
            case enNotificationType.Email:
                SendEmail(To, message); break;
            case enNotificationType.SMS:
                SendSMS(To, message); break;
            case enNotificationType.Fax:
                SendFax(To, message); break;

        }
    }

    private void SendEmail(string To, string message)
    {
        Console.WriteLine($"Send Email to {To}: {message}");
    }

    private void SendSMS(string To, string message)
    {
        Console.WriteLine($"Send SMS to {To}: {message}");
    }

    private void SendFax(string To, string message)
    {
        Console.WriteLine($"Send Fax to {To}: {message}");
    }
}

class Program
{ 
    static void Main()
    {
        NotificationService notificationService = new NotificationService();

        notificationService.SendNotification("john@example.fr", "Welcome to our service", NotificationService.enNotificationType.Email);
        notificationService.SendNotification("212645576859", "Your OTP code is 2345", NotificationService.enNotificationType.SMS);
        notificationService.SendNotification("212-645-576-859", "Check this important document", NotificationService.enNotificationType.Fax);

        Console.ReadLine();

    }
}

