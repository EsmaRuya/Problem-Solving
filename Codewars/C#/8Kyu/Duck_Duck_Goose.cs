/*
The objective of Duck, duck, goose is to walk in a circle, tapping on each player's head until one is chosen.

Task:
Given an array of Player objects and a position (first position is 1), return the name of the chosen Player.
name is a property of Player objects, e.g Player.name

Example:
duck_duck_goose([a, b, c, d], 1) should return a.name
duck_duck_goose([a, b, c, d], 5) should return a.name
duck_duck_goose([a, b, c, d], 4) should return d.name
*/

public class Kata
{
  public static string DuckDuckGoose(Player[] players, int goose)
  {
      int i = (goose-1) % players.Length;
      return players[i].Name;
  }
}

public class Player 
{
  public string Name {get;set;}
  
  public Player (string name) 
  {
	  this.Name = name;
  }
}