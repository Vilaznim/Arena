namespace TESArena;
using System;

public class Gladiator {
    //Standard stats for gladiators
    public string name { get; }
    public int maxHealth { get; }
    public int level { get; }
    public int health { get; }
    public int strength { get; }
    public float dodge { get; }
    public float doubleStrike { get; }

    public Gladiator(string Name = "Unnamed") {
        name = Name;
    }

    //Display stats method
    public void DisplayStats(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"MaxHealth: {maxHealth}");
        Console.WriteLine($"Strength: {strength}");
        Console.WriteLine($"Dodge chance: {dodge * 100}");
        Console.WriteLine($"Double strike chance: {doubleStrike * 100}");
    }

    public override string ToString() {
        return $"Gladiator: {name} | Level: {level} | Health: {health}";
    }

    //Lose match method
    public bool HasLost() {
        return health >= 0;
    }

    //Random number generator
    private static Random rand = new Random();

    //Lose health method 
    public bool LoseHealth() {

    }
} 