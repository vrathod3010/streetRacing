using System;
using SplashKitSDK;

public abstract class BotCar
{
    protected Window _gameWindow;
    protected Bitmap _botCarBitmap;
    protected double _x, _y;
    private int _lane;

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

    public Bitmap BotCarBitmap
    {
        get { return _botCarBitmap; }
    }
    public int Width
    {
        get
        {
            return _botCarBitmap.Width;
        }
    }

    public int Height
    {
        get
        {
            return _botCarBitmap.Height;
        }
    }

    public int Lane
    {
        get { return _lane; }
        set { _lane = value; }
    }
    public BotCar(Window gameWindow, int lane)
    {

        _gameWindow = gameWindow;
        _lane = lane;

        if (_lane == 1)
        {
            _x = 405;
        }
        else if (_lane == 2)
        {
            _x = 530;
        }
        else if (_lane == 3)
        {
            _x = 650;
        }
        else if (_lane == 4)
        {
            _x = 770;
        }
        else if (_lane == 5)
        {
            _x = 885;
        }
        _y = -100;
    }

    // public void Draw()
    // {
    //     _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    // }
    public abstract void Draw();

    public void HandleInput()
    {


        if (SplashKit.KeyDown(KeyCode.UpKey) || SplashKit.KeyDown(KeyCode.WKey))
        {
            _y += 2;
        }

    }

    public bool IsOffScreen(Window limit)
    {
        if (_y - 200 > limit.Height)
        {
            return true;
        }
        return false;
    }

    public bool CheckCollision(BotCar botCar)
    {
        if (_botCarBitmap.BitmapCollision(_x, _y, botCar.BotCarBitmap, botCar.X, botCar.Y))
        {
            return true;
        }
        return false;
    }
}

public class BotCar1 : BotCar
{

    public BotCar1(Window gameWindow, int lane) : base(gameWindow, lane)
    {
        _botCarBitmap = SplashKit.LoadBitmap("botCar1", "./Resources/images/botCar1.jpg");
    }
    public override void Draw()
    {
        _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    }
}

public class BotCar2 : BotCar
{

    public BotCar2(Window gameWindow, int lane) : base(gameWindow, lane)
    {
        _botCarBitmap = SplashKit.LoadBitmap("botCar2", "./Resources/images/botCar2.jpg");
    }
    public override void Draw()
    {
        _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    }
}

public class BotCar3 : BotCar
{

    public BotCar3(Window gameWindow, int lane) : base(gameWindow, lane)
    {
        _botCarBitmap = SplashKit.LoadBitmap("botCar3", "./Resources/images/botCar3.jpg");
    }
    public override void Draw()
    {
        _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    }
}
public class BotCar4 : BotCar
{

    public BotCar4(Window gameWindow, int lane) : base(gameWindow, lane)
    {
        _botCarBitmap = SplashKit.LoadBitmap("botCar4", "./Resources/images/botCar4.jpg");
    }
    public override void Draw()
    {
        _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    }
}
public class BotCar5 : BotCar
{

    public BotCar5(Window gameWindow, int lane) : base(gameWindow, lane)
    {
        _botCarBitmap = SplashKit.LoadBitmap("botCar5", "./Resources/images/botCar5.jpg");
    }
    public override void Draw()
    {
        _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    }
}
public class BotCar6 : BotCar
{

    public BotCar6(Window gameWindow, int lane) : base(gameWindow, lane)
    {
        _botCarBitmap = SplashKit.LoadBitmap("botCar6", "./Resources/images/botCar6.jpg");
    }
    public override void Draw()
    {
        _gameWindow.DrawBitmap(_botCarBitmap, _x, _y);
    }
}
