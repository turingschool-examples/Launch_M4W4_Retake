using System;
using System.Collections.Generic;

// Define the interface, make sure to update the name!
public interface InterfaceNameHere { }

// Implement the interface in different vehicle classes
public class Pig : InterfaceNameHere
{
	public bool IsHungry { get; set; }
	public bool IsTired { get; set; }
	
	public Pig()
	{
		IsHungry = true;
		IsTired = true;
	}

	public void Eat()
	{
		IsHungry = false;
	}

	public void Rest()
	{
		IsTired = false;
	}

	public string Play()
	{
		IsHungry = true;
		IsTired = true;
		return "I love to play in the mud!";
	}

}

public class Horse : InterfaceNameHere
{
	public bool IsHungry { get; set; }
	public bool IsTired { get; set; }
	public string Rider { get; set; }
	
	public Horse(string rider)
	{
		IsHungry = true;
		IsTired = true;
		Rider = rider;
	}

	public void Eat()
	{
		IsHungry = false;
	}

	public void Rest()
	{
		IsTired = false;
	}

	public string Play()
	{
		IsHungry = true;
		IsTired = true;
		return $"I love to carry {Rider}";
;	}

}
