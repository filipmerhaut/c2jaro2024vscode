namespace br02;

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Jaro 2024 Lekce 09 BR02");
        List<Clovek> telefonniSeznam = new List<Clovek>
		{
			new Clovek("Jarda", "Kadlec", 777123456),
			new Clovek("Honza", "Kratochvila", 777987654),
			new Clovek("Petr", "Novak", 778111222)
		};

        var adresar = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"TelefonniSeznam");
        if (!Directory.Exists(adresar))
        {
            Directory.CreateDirectory(adresar);
        }
        string soubor = Path.Combine(adresar, "TelefonniSeznam.xml");        

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Clovek>));
        using (StreamWriter sw = new StreamWriter(soubor))
        {
            xmlSerializer.Serialize(sw, telefonniSeznam);
        }

        using (StreamReader sr = new StreamReader(soubor))
        {
            var dataZeSouboru = xmlSerializer.Deserialize(sr) as List<Clovek>;
            foreach (Clovek line in dataZeSouboru)
            {
                Console.WriteLine($"Jméno: {line.Jmeno}, Příjmení: {line.Prijmeni}, Číslo: {line.TelCislo}");
            }
        }

    }
}
