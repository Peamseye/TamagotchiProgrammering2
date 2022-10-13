using System;

Console.WriteLine("TAMAGOTCHI");

Tamagotchi T1 = new Tamagotchi();

Console.WriteLine("What will your TAMAGOTCHI be called?");
T1.name = Console.ReadLine();

Console.WriteLine($"Your TAMAGOTCHI is now named {T1.name}");

while (T1.GetAlive() == true)
{
    Console.Clear();
    T1.PrintStats();
    Console.WriteLine();
    Console.WriteLine("What activity do you want to do?");
    Console.WriteLine($"(1) Teach {T1.name} a new word!");
    Console.WriteLine($"(2) Talk to {T1.name}!");
    Console.WriteLine($"(3) Feed {T1.name}!");
    Console.WriteLine($"(4) Skip!");

     string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    T1.Teach(word);
  }
  if (doWhat == "2")
  {
    T1.Hi();
  }
  if (doWhat == "3")
  {
    T1.Feed();
  }
  else
  {
    Console.WriteLine("Skipped!");
  }
  T1.Tick();
  
}

Console.WriteLine($"OH NO! {T1.name} is dead!");
Console.WriteLine("Press ENTER to quit");

Console.ReadLine();
