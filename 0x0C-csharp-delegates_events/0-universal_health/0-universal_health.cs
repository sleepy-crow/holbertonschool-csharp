using System;

/// <summary>
/// Class of the player
/// </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    /// <summary>
    /// constructor of the player
    /// </summary>
    /// <param name="name"> name of the play er</param>
    /// <param name="maxHp"> maximum of health the player is going to have </param>
	public Player(string name = "Player", float maxHp = 100f)
	{
        this.name = name;
        if (maxHp > 0)
        {
            this.hp = maxHp;
            this.maxHp = maxHp;
        }
        else
        {
            this.hp = 100f;
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        
	}
    /// <summary>
    /// Method tha prints how much health the player has
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }
}
