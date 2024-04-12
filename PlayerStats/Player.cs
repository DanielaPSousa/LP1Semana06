using System;


namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGame;
        private int wonGame;
    }
}

public float highScore
{
    get { return highScore; }
    set
    {
        if (value > highScore)
        {
                highScore = value;
        }
    }
}

public float WinRate
{
    get
    {
        if (playedGames == 0)
        {
            return 0;
        }
        else
        {
            return (float)wonGames / playedGames;
        }
    }
}
