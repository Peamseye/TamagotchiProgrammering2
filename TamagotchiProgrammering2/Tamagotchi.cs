using System;

public class Tamagotchi{

private int hunger;
private int boredom;
private List<string> words = new List<string>() {"Test"};
private bool isAlive;
private Random generator;
public string name;

public Tamagotchi()
{
isAlive = true;
generator = new Random();
}

private void ReduceBoredom(){
boredom--;
}

public void Feed(){
Console.WriteLine($"{name}'s hunger decreases.");
hunger-= 3;
if (hunger < 0){hunger = 0;}
}

public void Hi()
  {
    int wordNum = generator.Next(words.Count);
    ReduceBoredom();
    Console.WriteLine($"{name} says: {words[wordNum]}");
  }

public void Tick(){
 hunger += 1;
 boredom += 1; 

 if (hunger >= 10 || boredom >= 10){
    isAlive = false;
 }
}

public void PrintStats(){
    Console.WriteLine($"Name: {name} -|- {hunger} hunger -|- {boredom} boredom -|- Known vocabulary: {words}.");
}

public bool GetAlive(){
return isAlive;
}

}