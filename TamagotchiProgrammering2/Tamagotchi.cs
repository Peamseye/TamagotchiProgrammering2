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
hunger-= 3;
if (hunger < 0){
hunger = 0;
}
Console.WriteLine($"You fed {name}.");
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