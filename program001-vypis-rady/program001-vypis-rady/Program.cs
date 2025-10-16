using System.ComponentModel;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Olexandr Borshch ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé čísloooo. Zadejte první číslo řady znovu: ");
    }


    Console.Write("Zadejte druhé číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte druhe cislo rady znovu: ");
    }


    // Vystup zadanych hodnot
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Zadali jste hodnoty: ");
    Console.WriteLine($"První číslo řady: {first}");
    Console.WriteLine($"Posledni číslo řady: {last}");

    // Zadejte diference (krok)
    Console.Write("Zadejte diference (krok, celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte diference znovu: ");
    }

    Console.WriteLine("================================");
    Console.WriteLine("Prvni cislo: {0}; Posledni cislo: {1}; Diference: {2}", first, last, step);
    Console.WriteLine("================================");
    
}