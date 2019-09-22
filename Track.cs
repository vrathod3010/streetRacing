using System;
using SplashKitSDK;

public class Track
{
    private Window _gameWindow;

    private Bitmap _grass;
    private double _y, _x;
    private int _speed = 5;

    public Track(Window gameWindow)
    {
        _gameWindow = gameWindow;
        _grass = SplashKit.LoadBitmap("grass", "./Resources/images/grass1.jpg");
        _y = 0;
        _x = 355;
    }

    public void Draw()
    {
        double y = _y % 800;
        _gameWindow.DrawBitmap(_grass, 0, y);
        _gameWindow.DrawBitmap(_grass, 0, y - 800);
        _gameWindow.DrawBitmap(_grass, 975, y);
        _gameWindow.DrawBitmap(_grass, 975, y - 800);


        SplashKit.FillRectangle(Color.White, 10 + _x, 0, 5, 800);
        SplashKit.FillRectangle(Color.White, 605 + _x, 0, 5, 800);

        // Imagenary first lane
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 25 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 125 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 225 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 325 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 425 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 525 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 625 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 725 - 800, 5, 50);

        // current first lane
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 25, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 125, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 225, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 325, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 425, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 525, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 625, 5, 50);
        SplashKit.FillRectangle(Color.White, 135 + _x, y + 725, 5, 50);

        // Imagnary scond lane
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 25 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 125 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 225 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 325 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 425 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 525 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 625 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 725 - 800, 5, 50);

        // actual second lane
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 25, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 125, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 225, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 325, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 425, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 525, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 625, 5, 50);
        SplashKit.FillRectangle(Color.White, 255 + _x, y + 725, 5, 50);

        // img third lane
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 25 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 125 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 225 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 325 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 425 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 525 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 625 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 725 - 800, 5, 50);

        // actual 3 l
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 25, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 125, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 225, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 325, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 425, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 525, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 625, 5, 50);
        SplashKit.FillRectangle(Color.White, 375 + _x, y + 725, 5, 50);

        // image 4 l
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 25 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 125 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 225 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 325 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 425 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 525 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 625 - 800, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 725 - 800, 5, 50);

        // actual 4 l
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 25, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 125, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 225, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 325, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 425, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 525, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 625, 5, 50);
        SplashKit.FillRectangle(Color.White, 495 + _x, y + 725, 5, 50);
    }

    public void HandleInput()
    {

        _y += _speed;
        if (SplashKit.KeyDown(KeyCode.UpKey) || SplashKit.KeyDown(KeyCode.WKey))
        {
            _y += _speed;
        }
        if (SplashKit.KeyDown(KeyCode.LeftShiftKey) || SplashKit.KeyDown(KeyCode.RightShiftKey))
        {
            _y += _speed;
        }

    }
}