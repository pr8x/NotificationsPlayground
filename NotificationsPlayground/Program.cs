using DesktopNotifications.Apple;
using DesktopNotifications.FreeDesktop;
using DesktopNotifications.Windows;

internal class TestClass
{
    private static void Main(string[] args)
    {
        var m = new WindowsNotificationManager();
        var m1 = new FreeDesktopNotificationManager();
        var m2 = new AppleNotificationManager();
    }
}