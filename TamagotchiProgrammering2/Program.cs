using System;

Tamagotchi T1 = new Tamagotchi();

Console.WriteLine("What will your TAMAGOTCHI be called?");
T1.name = Console.ReadLine();

Console.WriteLine($"Your TAMAGOTCHI is now named {T1.name}");

while (T1.GetAlive() == true){
    Console.Clear();
    T1.PrintStats();
    Console.WriteLine("What activity do you want to do?");
    Console.WriteLine($"(1) Teach {T1.name} a new word!");
}



T1.PrintStats();

Console.ReadLine();
