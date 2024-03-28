// See https://aka.ms/new-console-template for more information
using NotificationApp;

var ana = new User("robert.badea@hotmail.com");
var george = new User("robert.badea99@gmail.com");

var emailNotification = new EmailNotification();
var smsNotification = new SMSNotification();
var pushNotification = new PushNotification();

var notificationService = new NotificationService(new List<INotification>()
{
    emailNotification,
    smsNotification,
    pushNotification
});

notificationService.SendNotification(george, "Acesta este un mesaj de notificare.");
notificationService.SendNotification(ana, "Acesta este un alt mesaj de notificare.");


Console.ReadKey();
