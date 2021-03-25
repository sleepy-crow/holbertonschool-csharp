using System;

public class Player
{
    public string name;
    public float maxHp;
    public float hp;
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
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + "/" + this.maxHp);
    }
}
