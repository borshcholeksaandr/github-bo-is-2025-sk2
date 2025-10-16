using System;

// Definujeme jmenný prostor pro naši aplikaci.
namespace SoucetSoucinCifer
{
    // Hlavní třída programu.
    class Program
    {
        // Vstupní bod aplikace.
        static void Main(string[] args)
        {
            // Deklarace proměnných.
            int cislo;          // Uloží číslo zadané uživatelem.
            int soucet = 0;     // Inicializace součtu na 0.
            int soucin = 1;     // Inicializace součinu na 1 (kvůli násobení).
            int puvodniCislo;   // Pro uložení původní hodnoty čísla pro výpis.

            // Výzva pro uživatele k zadání čísla.
            Console.Write("Zadejte prosím celé číslo: ");
            
            // Načtení a převedení vstupu na celé číslo (int).
            // Používáme blok try-catch pro ošetření případné chyby,
            // kdyby uživatel nezadal platné číslo.
            try
            {
                cislo = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Chyba: Zadaný vstup není platné celé číslo.");
                return; // Ukončení programu v případě chyby.
            }
            catch (OverflowException)
            {
                Console.WriteLine("Chyba: Zadané číslo je příliš velké nebo příliš malé.");
                return; // Ukončení programu v případě chyby.
            }
            
            // Uložíme si původní hodnotu čísla pro finální výpis.
            puvodniCislo = cislo;

            // Pokud je zadané číslo záporné, převedeme ho na kladné pro výpočet.
            // Znaménko neovlivňuje cifry samotné.
            if (cislo < 0)
            {
                cislo = -cislo;
            }

            // Pokud je zadané číslo 0, součet i součin jsou 0.
            if (cislo == 0)
            {
                soucet = 0;
                soucin = 0;
            }
            else
            {
                // Cyklus, který probíhá, dokud je číslo větší než 0.
                while (cislo > 0)
                {
                    // 1. Získání poslední cifry pomocí operátoru modulo (%).
                    //    Např. 123 % 10 = 3
                    int cifra = cislo % 10;
                    
                    // 2. Přičtení získané cifry k celkovému součtu.
                    soucet += cifra; // Stejné jako soucet = soucet + cifra;
                    
                    // 3. Vynásobení získané cifry s celkovým součinem.
                    soucin *= cifra; // Stejné jako soucin = soucin * cifra;
                    
                    // 4. Odstranění poslední cifry pomocí celočíselného dělení.
                    //    Např. 123 / 10 = 12
                    cislo /= 10; // Stejné jako cislo = cislo / 10;
                }
            }

            // Výpis výsledků.
            Console.WriteLine($"Pro číslo {puvodniCislo}:");
            Console.WriteLine($"Součet cifer je: {soucet}");
            Console.WriteLine($"Součin cifer je: {soucin}");
        }
    }
}