namespace br01;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Jaro 2024 Lekce 09 BR01");

        List<Clovek> telefonniSeznam = new List<Clovek>
		{
			new Clovek("Jarda", "Kadlec", 777123456),
			new Clovek("Honza", "Kratochvila", 777987654),
			new Clovek("Petr", "Novak", 778111222)
		};
		
		//1. Vytvorte slozku TelefonniSeznam v adresari Appdata pro konkretniho uzivatele
		//2. Do souboru telefonniSeznam.csv ulozte obsah seznamu telefonniSeznam tak,
		//   ze kazdy zaznam bude na jednom radku a oddelene budou carkami
		//3. Napiste cyklus, ktery soubor precte a zpatky ho ulozi do noveho seznamu

        String slozka = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TelefonniSeznam");
        if (!Directory.Exists(slozka))
        {
            Directory.CreateDirectory(slozka);
        }

        String cesta = Path.Combine(slozka, "telefonniSeznam.csv");
        File.WriteAllText(cesta, "Jmeno; Prijmeni; TelCislo" + Environment.NewLine);

        var radky = telefonniSeznam.Select(radek=>$"{radek.Jmeno}; {radek.Prijmeni}; {radek.TelCislo} ");
        
        File.AppendAllLines(cesta, radky);

        if (File.Exists(cesta))
        {
            var nactenoZeSouboru = File.ReadAllLines(cesta);
            foreach (string radek in nactenoZeSouboru)
            {
                Console.WriteLine(radek);
            }
        }
        else
        {
            Console.WriteLine("Soubor nenalezen");
        }
	}
    
}
