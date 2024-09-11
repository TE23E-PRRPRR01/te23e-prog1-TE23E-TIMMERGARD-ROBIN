// Program för att konvertera från Fahrenheit till Celsius
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Program för att konvertera från Fahrenheit till Celsius!");

// Läsa in temperaturen i Fahrenheit
Console.Write("Ange temperaturen i Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Konvertera Fahrenheit till Celsius
double tempCelsius = (tempFahrenheit -32) * 5 / 9;

// Skriva ut reslutatet med decimaler
Console.WriteLine($"{tempFahrenheit} Fahrenheit blir {tempCelsius} Celsius");