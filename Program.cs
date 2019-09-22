using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window gameWindow = new Window("Street Racing", 1330, 800);
        StreetRacing streetRacing = new StreetRacing(gameWindow);
        while (!(gameWindow.CloseRequested || streetRacing.Quit))
        {
            SplashKit.ProcessEvents();
            streetRacing.HandleInput();
            streetRacing.Update();
            streetRacing.Draw();
        }
    }
}
