using System;
using SplashKitSDK;
using System.Collections.Generic;



public class StreetRacing
{
    private PlayerCar _playerCar;
    private bool _isGameOver;
    private List<BotCar> _botCars;
    private Track _track;
    private Window _gameWindow;

    public StreetRacing(Window gameWindow)
    {
        _gameWindow = gameWindow;
        _playerCar = new PlayerCar(_gameWindow);
        _track = new Track(_gameWindow);
        _botCars = new List<BotCar>();
        _isGameOver = false;
    }

    public void Draw()
    {

        if (!_isGameOver)
        {
            _gameWindow.Clear(Color.RGBColor(153, 153, 153));
            _track.Draw();
            _playerCar.Draw();
            DrawBotCars();
        }
        else
        {
            _gameWindow.Clear(Color.White);
            DrawGameOver();
        }
        _gameWindow.Refresh(60);
    }

    private void DrawBotCars()
    {
        _botCars.ForEach(delegate (BotCar botCar)
           {
               botCar.Draw();
           });
    }


    public void Update()
    {
        RandomlyAddCar();
        RemoveOffScreenCars();
        CheckCollosion();
    }

    public void HandleInput()
    {
        _playerCar.HandleInput();
        BotCarsHandleInput();
        _playerCar.stayeOnWindow(_gameWindow);
        _track.HandleInput();
    }
    public void BotCarsHandleInput()
    {
        _botCars.ForEach(delegate (BotCar botCar)
        {
            botCar.HandleInput();
        });
    }
    public BotCar RandomCar()
    {
        float randomSelect = SplashKit.Rnd();
        Random r = new Random();
        int randomLane = r.Next(1, 5);


        BotCar botCar;
        if (randomSelect < 0.1666)
        {
            botCar = new BotCar1(_gameWindow, randomLane);
        }
        else if (randomSelect < 0.3333)
        {
            botCar = new BotCar2(_gameWindow, randomLane);
        }
        else if (randomSelect < 0.50)
        {
            botCar = new BotCar3(_gameWindow, randomLane);
        }

        else if (randomSelect < 0.6666)
        {
            botCar = new BotCar4(_gameWindow, randomLane);
        }
        else if (randomSelect < 0.8332)
        {
            botCar = new BotCar5(_gameWindow, randomLane);
        }
        else
        {
            botCar = new BotCar6(_gameWindow, randomLane);
        }
        return botCar;
    }

    public void RandomlyAddCar()
    {
        if (SplashKit.Rnd() < 0.015)
        {
            BotCar randomBotCar = RandomCar();
            _botCars.ForEach(delegate (BotCar botCar)
            {
                if (botCar.CheckCollision(randomBotCar))
                {
                    randomBotCar.Y -= 600;
                }
            });
            _botCars.Add(randomBotCar);
        }
    }

    public void RemoveOffScreenCars()
    {
        List<BotCar> deleteBotCars = new List<BotCar>();
        _botCars.ForEach(delegate (BotCar botCar)
        {
            if (botCar.IsOffScreen(_gameWindow))
            {
                deleteBotCars.Add(botCar);
            }
        });

        deleteBotCars.ForEach(delegate (BotCar botCar)
       {
           _botCars.Remove(botCar);
       });
    }

    public void CheckCollosion()
    {
        _botCars.ForEach(delegate (BotCar botCar)
        {
            if (_playerCar.CheckCollision(botCar))
            {
                _isGameOver = true;
            }
        });
    }

    public void DrawGameOver()
    {
        _gameWindow.DrawText("GAME OVER", Color.Black, "Dank Mono", 30, 270 + 355, 300);
        // _gameWindow.DrawText($"Your Score : {_Score}", Color.Black, "Dank Mono", 30, 350, 330);
        _gameWindow.DrawText($"Press Enter to Play again...", Color.Black, "Dank Mono", 30, 220 + 355, 360);
        if (SplashKit.KeyDown(KeyCode.ReturnKey))
        {
            _isGameOver = false;
            _botCars.Clear();
        }
    }
}