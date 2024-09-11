// Program för att räkna ut kostand av att hyra en bil
Console.Clear();
Console.WriteLine("Program för att räkna ut kostnad av att hyra en bil");


// Läsa in hur många mil bilen har kört
Console.Write("Ange hur många mil bilen har kört: ");
int miltal = int.Parse(Console.ReadLine());

// Läsa in hur många dagar bilen har blivit hyrd
Console.Write("Ange hur många dagar bilen har blivit hyrd: ");
int dagar = int.Parse(Console.ReadLine());

// Räkna ut hur mycket det kostar för användaren när den betalar
double pris = miltal * 5 + dagar * 100 + 500;

// Räkna ut hur mycket det kostar för använder när den betalar
Console.WriteLine($"Det kommer att kosta dig {pris}kr");