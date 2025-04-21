


using DecoratorPattern.Classes;
using DecoratorPattern.Interfaces;

new FacebookNotificationDecorator(new WhatsAppNotificationDecorator(new EmailNotifier())).Notify();