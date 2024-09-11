// Skapa ett program som implementerar valfria åldersregler.
//Välj 4 åldersgränser och associera dem med något som är tillåtet att göra vid den åldern.
Console.Clear();
Console.WriteLine("Program som kollar dina kunskaper om ålder för skolnivå i Sverige");
Console.Write("Hur gammal man vara för att gå i olika skolstadien i Sverige?: ");

// Användaren ska gissa hur gammal man är i vissa stadien i skolan

Console.Write("Hur gammal är du?");
string ålderText = Console.ReadLine(); // Läs in texten
int ålder = int.Parse(ålderText); //Konvertera texten till heltal

if (ålder == 6 || ålder == 7 || ålder 8)
{
    Console.WriteLine("Såhär gammal är man när man går i lågstadiet!");
}
else if (ålder == 9 || ålder == 10 || ålder == 11)
{
    Console.WriteLine("Såhär gammal är man när man går i mellanstadiet!");
}
else if (ålder == 12 || ålder 13 || ålder 14)
{
    Console.WriteLine("Såhär gammal är man när man går i högstadiet!");
}