using System;

public class Player
{
    private float highScore;
    private int playedGames;
    private int wonGames;
    public float HighScore
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

    public string Name { get; }


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

    public Player(string playerName)
    {

        Name = playerName;
        highScore = 0;
        playedGames = 0;
        wonGames = 0;
    }
    public void PlayGame(bool win)
    {
 
        playedGames++;

        if (win)
        {
            wonGames++;
        }
    }
}

