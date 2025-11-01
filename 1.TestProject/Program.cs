// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Random dice = new Random();
Random dice = new(); // New version don't require the class to be repeated
int roll = dice.Next(1, 7);
Console.WriteLine("Roll value : "+roll);