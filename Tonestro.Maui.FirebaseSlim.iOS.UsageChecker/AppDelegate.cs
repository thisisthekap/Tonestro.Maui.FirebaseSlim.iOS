namespace Tonestro.Maui.FirebaseSlim.iOS.UsageChecker;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        var analyticsManager = Tonestro.Maui.FirebaseSlim.iOS.AnalyticsManagerSlim.Shared;

        var firebaseAppInstanceId = analyticsManager.AppInstanceId;
        Console.WriteLine($"ASDF: {firebaseAppInstanceId}");
        if (string.IsNullOrWhiteSpace(firebaseAppInstanceId))
        {
            throw new Exception("something seems to be wrong with the binding");
        }

        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();
        vc.View!.AddSubview(new UILabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = "Hello, iOS!",
            AutoresizingMask = UIViewAutoresizing.All,
        });
        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}