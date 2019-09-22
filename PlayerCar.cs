using System;
using SplashKitSDK;

public class PlayerCar
{
    private Window _gameWindow;
    private Bitmap _playerCarBitmap;
    private double _x, _y;

    private int _horizontalSpeed = 10;


    public double X
    {
        get { return _x; }
        set { _x = value; }
    }

    public double Y
    {
        get { return _y; }
        set { _y = value; }
    }

    public int Width
    {
        get
        {
            return _playerCarBitmap.Width;
        }
    }

    public int Height
    {
        get
        {
            return _playerCarBitmap.Height;
        }
    }
    public PlayerCar(Window gameWindow)
    {
        _gameWindow = gameWindow;
        _playerCarBitmap = SplashKit.LoadBitmap("playerCar", "./Resources/images/playerCar.jpg");
        _x = (_gameWindow.Width - Width) / 2 + 10;
        _y = 690;
    }

    public void Draw()
    {
        _gameWindow.DrawBitmap(_playerCarBitmap, _x, _y);
    }

    public void HandleInput()
    {
        int speed = _horizontalSpeed;
        if (SplashKit.KeyDown(KeyCode.LeftKey) || SplashKit.KeyDown(KeyCode.AKey))
        {
            _x -= speed;
        }
        if (SplashKit.KeyDown(KeyCode.RightKey) || SplashKit.KeyDown(KeyCode.DKey))
        {
            _x += speed;
        }
    }

    public void stayeOnWindow(Window limit)
    {
        const int GAP = 15;
        if (_x < GAP + 355)
        {
            _x = GAP + 355;
        }

        if (_x > ((limit.Width - 355) - Width) - GAP)
        {
            _x = ((limit.Width - 355) - Width) - GAP;
        }

    }

    public bool CheckCollision(BotCar botCar)
    {
        if (_playerCarBitmap.BitmapCollision(_x, _y, botCar.BotCarBitmap, botCar.X, botCar.Y))
        {
            return true;
        }
        return false;
    }
}