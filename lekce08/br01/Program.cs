namespace br01;
// Vytvořte abstraktní třídu PohadkovaBytost a v ní abstraktní metodu NapisJakTravisVolnyCas
// Vytvorte tridy Princezna, Rytir, Carodenice, ktere dedi PohadkovouBytost
// Naimplementujte metodu NapisJakTravisVolnyCas - vypsanemu textu na konzoli se meze nekladou
// Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C#2 Jaro 2024 Lekce 08 Breakout Room 1");        
        /*
        //první způsob - napřed vytvořím jednotlivé pojmenované instance objektů a teprve poté je dám do kolekce List<>
        PohadkovaBytost zlatovlaska = new Princezna();        
        PohadkovaBytost krason = new Rytir();        
        PohadkovaBytost jaga = new Carodejnice();        
        var zverinec = new List<PohadkovaBytost>(){zlatovlaska, krason, jaga};
        */

        //druhý způsob - vytvořím nepojmenované instance objektů přímo při vytváření kolekce List<>
        var zverinec = new List<PohadkovaBytost>(){new Princezna(), new Rytir(), new Carodejnice(), new Princezna()};
        foreach (PohadkovaBytost bytost in zverinec)
        {
            bytost.NapisJakTravisVolnyCas();
        }
    }

    public abstract class PohadkovaBytost
    {
        public abstract void NapisJakTravisVolnyCas();
    }

    public class Princezna : PohadkovaBytost
    {
        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Obrážím bály");
        }
    }

    public class Rytir : PohadkovaBytost
    {
        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Chytám draky");
        }
    }

    public class Carodejnice : PohadkovaBytost
    {
        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Vařím lektvar");
        }
    }
}

