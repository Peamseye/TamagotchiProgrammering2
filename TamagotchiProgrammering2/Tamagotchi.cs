using System;

public class Tamagotchi{

private int hunger = 0;
private int boredom = 0;
List<string> words = new List<string>();
private bool isAlive = true;
private Random generator = new Random();
public string name = ("");

private void ReduceBoredom(){
boredom--;
}

public void Feed(){
hunger--;
Console.WriteLine($"You fed {name}.");
}

public void Tick(){
 hunger += 1;
 boredom += 1; 

 if (hunger >= 10 || boredom >= 10){
    isAlive = false;
 }
}

//public bool GetAlive(){
  //  isAlive = true;
//}

public void PrintStats(){
    Console.WriteLine($"{name} has {hunger} hunger and {boredom} boredom.");
}



}