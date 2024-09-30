// Hur man skapar och använder lisor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur en kortlek!");


// Ett annat exempel. Lista på 3 årtal
// List<int> årtal = [1957, 1969, 1989];

// Skapa en lista kort
//List<string> kortlek = ["Ess", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio", "Tio", "Knekt", "Dam", "Kung"];
//  List<string> kortlek = ["🂱	", "🂲	", "🂳	", "🂴	", "🂵	", "🂶	", "🂷	", "🂸	", "🂹	", "🂺	", "🂻	", "🂽	", "🂾	"];
List<string> kortlek = [ "", "🂱	", "🂲	", "🂳	", "🂴	", "🂵	", "🂶	", "🂷	", 
"🂸	", "🂹	", "🂺	", "🂻	", "🂽	", "🂾	"];

int antal = 5;
while (antal > 0)
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    // Console.WriteLine($"Det slumpade index = {index}");

    // Plocka ut det sjunde kortet
    string kort = kortlek[index];

    // Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    // Skriv ut sjunde kortet
    Console.WriteLine($"Ett av de slumpade korten är {kort}");

    // Räkna ned
    antal--;
}