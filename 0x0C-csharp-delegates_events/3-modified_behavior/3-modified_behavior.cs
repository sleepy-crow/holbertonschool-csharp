﻿using System;

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
    
    /// <summary>
    /// delegate for the damage
    /// </summary>
    /// <param name="damage"> damage taked </param>
    public delegate void CalculateHealth(float damage);

    /// <summary>
    /// method that tells how much damage is taken
    /// </summary>
    /// <param name="damage"> damake taken </param>
    public void TakeDamage(float damage)
    {
        // this variable is going to take temporary
        // the new value of the hp
        // after taking the damage
        float dhp = 0f;
        if (damage > 0)
        {
            Console.WriteLine(this.name + " takes " + damage + " damage!");
            dhp = hp - damage;
            ValidateHP(dhp);
        }
        else
        {
            Console.WriteLine(this.name + " takes 0 damage!");
        }
    }
    /// <summary>
    /// method that tells how much is healed the hp
    /// </summary>
    /// <param name="heal"> heal to the hp </param>
    public void HealDamage(float heal)
    {
        // this variable is going to take temporary
        // the new value of the hp
        // after taking the healing
        float thp = 0f;
        if (heal > 0)
        {
            Console.WriteLine(this.name + " heals " + heal + " HP!");
            thp = this.hp + heal;
            ValidateHP(thp);
        }
        else
        {
            Console.WriteLine(this.name + " heals 0 HP!");
        }
    }
    /// <summary>
    /// this method check how much hp the player class is going
    /// get next
    /// </summary>
    /// <param name="newHp"> the new hp to check and set </param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }
        else
        {
            this.hp = newHp;
        }
    }
    /// <summary>
    /// This method applies the value of
    /// damage or heal the player class
    /// is going to take on the modifier
    /// </summary>
    /// <param name="baseValue"> base value to apply </param>
    /// <param name="modifier"> the modifier of the value </param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float returner = baseValue;
        if (modifier == Modifier.Weak)
            return returner / 2;

        if (modifier == Modifier.Strong)
            return returner * 1.5f;
        
        return returner;
    }
}

/// <summary>
/// enum with the modifiers to the base value
/// </summary>
public enum Modifier

{
    /// <sumary>
    /// modifier that returns half the vaule
    /// </sumary>
    Weak,
    /// <sumary>
    /// modifier that returns the same value
    /// </sumary>
    Base,
    /// <sumary>
    /// modifier that returns the of 1.5 the value
    /// </sumary>
    Strong
}

/// <summary>
/// delegate of the calculation of modifier
/// </summary>
/// <param name="baseValue"> base value to apply </param>
/// <param name="modifier"> the modifier of the value </param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);