// Program för att räkna ut BMI
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Program för att räkna ut BMI");

//Läsa in vikten i kilogram
Console.Write("Ange din vikt i kilogram: ");
double viktKG = double.Parse(Console.ReadLine());

// Läsa in längden i meter
Console.Write("Ange din längd i meter: ");
double längdM = double.Parse(Console.ReadLine());

// Räkna ut Body Mass Index
double BMI = viktKG / (längdM * längdM);

//Skriva ut resultatet av BMI med decimaler
Console.WriteLine($"Din BMI är {BMI:00.00}");