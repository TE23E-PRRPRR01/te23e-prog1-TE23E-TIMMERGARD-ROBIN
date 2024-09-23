// Program som skriva/läsa textfil
Console.Clear();
Console.WriteLine("Program som skriver/läser textfil");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

string val = "";

while (true)
{
    Console.Clear();
    Console.Write($"""
    Välkommen till TextEditor
    1. Skriver till fil
    2. Läser från fil
    3. Avslutar programmet
    Välj ett av alternativen ovan: 
    """);
    val = Console.ReadLine();
    
    if (val == "1")
  {
    Console.Clear();
    Console.Write("Skriv en text: ");
    string texten = Console.ReadLine();
    Console.Write("Vad ska filen heta?: ");
    string namn = Console.ReadLine();
     File.WriteAllText($"{namn}.txt", texten);
  }
  else if (val == "2")
  {

    try
    {
        Console.Clear();
        Console.Write("Namn på filen: ");
        string namn = Console.ReadLine();
        string texten = File.ReadAllText($"{namn}.txt");
        Console.Write($"{texten}"); 
    }
    catch (Exception ex)
    {
        Console.Clear();
    }
  }
  else if (val == "3")
  {     
    Console.Clear();
    Console.WriteLine("Hejdå!");
    break;
    Console.Clear();
  }
  else
  {
    Console.WriteLine("Ogiltigt alternativ, försök igen");
  }


}
