// Ett program som är liknande en quiz

// Början av min quiz där jag inleder men en fråga som undrar vad användaren heter
while (true)
{
Console.Clear();
Console.WriteLine("Idag ska du få testa min quiz!");
Console.Write("Vad heter du?: ");
string namn = Console.ReadLine();
string svar;
int poäng = 0;
// Första frågan i min quiz
Console.WriteLine($"Hej, {namn}!");
Console.WriteLine("Vad heter du?");
Console.WriteLine($"A: {namn}");
Console.WriteLine("B: Britt-Marie");
Console.WriteLine("C: Klas-Göran");
svar = Console.ReadLine().ToUpper();
if (svar == "A") poäng++;
Console.Clear();
// Fråga nummer 2
Console.WriteLine("Vilken är Sveriges största stad?"); 
Console.WriteLine("A: Kalmar");
Console.WriteLine("B: Kiruna");
Console.WriteLine("C: Stockholm");
svar = Console.ReadLine().ToUpper();
if (svar == "C") poäng++;
Console.Clear();
// Fråga nummer 3
Console.WriteLine("Vem är Sveriges kung just nu?");
Console.WriteLine("A: Gustav Vasa");
Console.WriteLine("B: Carl Gustav XVI");
Console.WriteLine("C: Donald Trump");
svar = Console.ReadLine().ToUpper();
if (svar == "B") poäng++;
Console.Clear();
// Fråga nummer 4
Console.WriteLine("Vilket datum firas Sveriges Nationaldag?");
Console.WriteLine("A: 6 Juli");
Console.WriteLine("B: 6 Juni");
Console.WriteLine("C: 6 Maj");
svar = Console.ReadLine().ToUpper();
if (svar == "B") poäng++;
Console.Clear();
// Slutet av min quiz där jag berättar hur många poäng spelaren fick och sedan säger tack och hejdå
Console.WriteLine($"Du fick {poäng} av 4 poäng!");
Console.WriteLine("Tack för att du spelade min Quiz!");

    Console.Write("Vill du spela en gång till? (J/N): ");
    string slut = Console.ReadLine().ToUpper();
    if (slut == "N")
{
    break;
}

}
// Slut på spelet
Console.WriteLine("Okej, tack för att du spelade!");