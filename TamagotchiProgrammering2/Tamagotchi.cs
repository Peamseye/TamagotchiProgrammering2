using System;
using System.Collections.Generic;


public class Tamagotchi{

private int hunger;
private int boredom;
private List<string> words = new List<string>() {"Helo"};
private bool isAlive;
private Random generator;
public string name;

public Tamagotchi()
{
generator = new Random();
isAlive = true;
}

private void ReduceBoredom(){
boredom-= 3;
if (boredom < 0) {boredom = 0;}
}

public void Feed(){
Console.WriteLine($"{name}'s hunger decreases.");
hunger-= 3;
if (hunger < 0){hunger = 0;}
}

public void Hi()
  {
    int wordNum = generator.Next(words.Count);
    Console.WriteLine($"{name} says: {words[wordNum]}");
    ReduceBoredom();
  }

public void Tick(){
 hunger ++;
 boredom ++; 

 if (hunger > 10 || boredom > 10) {isAlive = false;}
}

public void Teach(string word)
  {
    Console.WriteLine($" {name} has learned: {word}");
    words.Add(word);
    ReduceBoredom();
  }


public void PrintStats(){
    Console.WriteLine($"Name: {name} -|- {hunger} hunger -|- {boredom} boredom -|- Known vocabulary: {words}.");
}

public bool GetAlive(){
return isAlive;
}

}