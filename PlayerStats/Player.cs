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