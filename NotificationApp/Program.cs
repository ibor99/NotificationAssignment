// See https://aka.ms/new-console-template for more information
using NotificationApp;

var emailNotification = new EmailNotification();
var smsNotification = new SMSNotification();
var pushNotification = new PushNotification();

var notificationService = new NotificationService(new List<INotification>()
{
    emailNotification,
    smsNotification,
    pushNotification
});

notificationService.SendNotification("Test Notification");

Console.ReadKey();
