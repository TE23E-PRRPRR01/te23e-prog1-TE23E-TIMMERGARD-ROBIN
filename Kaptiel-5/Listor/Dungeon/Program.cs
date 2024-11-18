﻿// Ett dungeon-spel med massa rum, saker, fiender, skatter...
Console.Clear();
Console.WriteLine("Ett dungeon-spel!");

// Programvariabler (Statevariables)
string rum = "hallen";
List<string> inventarie = [];

// Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra?: ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser några gamla tavlor.");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine("... du går in i nästa rum...");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i rum 1");
        Console.WriteLine("1. Kolla runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra?: ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet.");
            Console.Write("Vill du plocka upp nyckel (j/n)");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventarie.Add("nyckel");
                Console.WriteLine("Du plockade upp nyckeln.");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet");
            }
        }
        else if (val == "2")
        {
            rum = "hallen";
            Console.WriteLine(" .. du går tillbaka till hallen.. ");
        }
        else if (val == "3")
        {
            rum = "rum 2";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i rum 2");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till rum 1");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en pizza på bordet");
            Console.Write("Vill du äta den? (j/n): ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                Console.WriteLine("Du åt pizzan och blev förgiftad!");
                Console.WriteLine("Game over!");
                break;
            }
            else
            {
                Console.WriteLine("Du lämnar pizzan på bordet.");
                Console.Write("Vill du plocka upp pizzan? (j/n)");
                val = Console.ReadLine().ToLower();
                if (val == "j")
                {
                    inventarie.Add("Pizza");
                    Console.WriteLine("Du plockade upp pizzan!");
                }
                else
                {
                    Console.WriteLine("Du lämnar pizzan på bordet!");
                }
            }
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" .. du går tillbaka till rum 1.. ");
        }
        else if (val == "3")
        {
            rum = "rum 3";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }
    else if (rum == "3")
    {
        Console.WriteLine("Du är i rum 3");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till rum 2");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser ett monster som sover");
            Console.Write("Vill du väcka den? (j/n): ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                Console.WriteLine("Du väckte monstret!");
                Console.WriteLine("");
                break;
            }
            else
            {
                Console.WriteLine("Du lämnar pizzan på bordet.");
                Console.Write("Vill du plocka upp pizzan? (j/n)");
                val = Console.ReadLine().ToLower();
                if (val == "j")
                {
                    inventarie.Add("Pizza");
                    Console.WriteLine("Du plockade upp pizzan!");
                }
                else
                {
                    Console.WriteLine("Du lämnar pizzan på bordet!");
                }
            }
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" .. du går tillbaka till rum 1.. ");
        }
        else if (val == "3")
        {
            rum = "rum 3";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }

}