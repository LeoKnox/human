using System;

public class Human
{
	public string Name;
	public int Strength;
	public int Intelligence;
	public int Dexterity;
	private int health;
	
	public Human(string called)
	{
		Name = called;
		Strength = 3;
		Intelligence = 3;
		Dexterity = 3;
		health = 100;
	}
	
	public Human(string called, int str, int intel, int dex, int heal)
	{
		Name = called;
		Strength = str;
		Intelligence = intel;
		Dexterity = dex;
		health = heal;
	}
	
	public int damage
	{
		get { return health; }
	}
	
	public int Attack(Human target)
	{
		health -= 5*Strength;
		return health;
	}
}
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}