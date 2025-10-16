using System;

// Jmenný prostor pro náš program
namespace program002a_soucet_cifer
{
    // Hlavní třída programu
    class Program
    {
        // Vstupní bod aplikace
        static void Main(string[] args)
        {
            // Smyčka pro opakování programu
            string again = "a";
            while (again.ToLower() == "a") // Používáme ToLower() pro akceptování 'a' i 'A'
            {
                // Vyčištění konzole a výpis hlavičky
                Console.Clear();
                Console.WriteLine("********************************************");
                Console.WriteLine("****** Součet a součin cifer čísla *******");
                Console.WriteLine("********************************************");
                Console.WriteLine("************ Oleksandr Borshch *************");
                Console.WriteLine("************** 2.10.2025 *******************");
                Console.WriteLine("********************************************");
                Console.WriteLine();

                // Načtení vstupu s validací
                Console.Write("Zadejte celé číslo: ");
                int cislo;
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.Write("Nezadali jste platné celé číslo. Zkuste to znovu: ");
                }

                // Uložíme si původní číslo pro pozdější výpis
                int puvodniCislo = cislo;

                // Inicializace proměnných pro výpočet
                int soucet = 0;
                int soucin = 1; // Musí být 1, protože násobení nulou by vždy dalo 0

                // Pokud je zadané číslo záporné, pro výpočet použijeme jeho absolutní hodnotu
                if (cislo < 0)
                {
                    cislo = -cislo;
                }
                
                // Speciální případ pro nulu
                if (puvodniCislo == 0)
                {
                    soucet = 0;
                    soucin = 0;
                }
                else
                {
                    // Cyklus, který probíhá, dokud máme z čísla co oddělovat
                    while (cislo > 0)
                    {
                        // 1. Získáme poslední cifru pomocí operátoru modulo (%)
                        //    (např. 123 % 10 vrátí 3)
                        int cifra = cislo % 10;

                        // 2. Přičteme cifru k součtu
                        soucet += cifra; // to samé jako soucet = soucet + cifra;

                        // 3. Vynásobíme cifru se součinem
                        soucin *= cifra; // to samé jako soucin = soucin * cifra;

                        // 4. Odstraníme poslední cifru pomocí celočíselného dělení (/)
                        //    (např. 123 / 10 vrátí 12)
                        cislo /= 10; // to samé jako cislo = cislo / 10;
                    }
                }

                // Výpis výsledků
                Console.WriteLine();
                Console.WriteLine("============================================");
                Console.WriteLine($"Pro zadané číslo: {puvodniCislo}");
                Console.WriteLine($"Součet jeho cifer je: {soucet}");
                Console.WriteLine($"Součin jeho cifer je: {soucin}");
                Console.WriteLine("============================================");
                Console.WriteLine();

                // Dotaz na opakování
                Console.Write("Pro opakování programu stiskněte 'a', pro ukončení libovolnou jinou klávesu: ");
                string? input = Console.ReadLine();
                again = input ?? ""; // Zabrání chybě, pokud je vstup null
            }
        }
    }
}