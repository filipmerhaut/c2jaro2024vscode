namespace br02;
//https://dotnetfiddle.net/rwz8Y8
//napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
//implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
//vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C#2 Jaro 2024 Lekce 08 Breakout Room 2"); 
        
        Obdelnik obd1 = new Obdelnik(5,30);        
        Console.WriteLine("Obdélník ({0})", obd1.id);
        Console.WriteLine("Šířka: {0} Výška: {1}", obd1.Sirka, obd1.Vyska);
        Console.WriteLine("Obvod: {0} Obsah: {1}", obd1.VypocitejObvod(), obd1.VypocitejObsah());
        Console.WriteLine();
        
        Kruh kr1 = new Kruh(3);
        Console.WriteLine("Kruh ({0})", kr1.id);
        Console.WriteLine("Poloměr: {0}", kr1.Polomer);
        Console.WriteLine("Obvod: {0} Obsah: {1}", kr1.VypocitejObvod(), kr1.VypocitejObsah());

        Kruh kr2 = new Kruh(5);
        List<Kruh> kruhy = new List<Kruh>() {kr1, kr2};
        //kruhy.Sort(); //vyhodí výjimku Unhandled exception. System.InvalidOperationException: Failed to compare two elements in the array.
        Console.WriteLine();

        List<Tvar> tvary = new List<Tvar>() {obd1, kr1, new Kruh(2), new Obdelnik(2,2), new Obdelnik(8,2), new Kruh(6)};
        foreach (Tvar tvar in tvary)
        {
            Console.WriteLine("id: {0}", tvar.id);
            if (tvar is Obdelnik)
                Console.WriteLine("Obdélník. Šířka {0} Výška {1}", ((Obdelnik)tvar).Sirka, ((Obdelnik)tvar).Vyska);
            if (tvar is Kruh)
                Console.WriteLine("Kruh. Poloměr {0}", ((Kruh)tvar).Polomer);
            Console.WriteLine("Obsah: {0}", tvar.VypocitejObsah());
        }
        Console.WriteLine();

        //Otestování metody Sort()
        List<Obdelnik> obdelniky = new List<Obdelnik>(){obd1, new Obdelnik(1,1), new Obdelnik(5,2), new Obdelnik(3,3)};
        
        Console.WriteLine("Kolekce obdélníků před voláním metody Sort()");
        foreach (Tvar objekt in obdelniky)
            Console.WriteLine("{0} Obsah: {1}", objekt.id, ((Obdelnik)objekt).VypocitejObsah());
        
        obdelniky.Sort();    // to, že jsme v Obdelniku implementovali IComparable nám dovolí volat metodu Sort(). Jinak by nefungovala!
        
        Console.WriteLine();
        Console.WriteLine("Kolekce obdélníků po volání metody Sort()");
        foreach (Tvar objekt in obdelniky)
            Console.WriteLine("{0} Obsah: {1}", objekt.id, ((Obdelnik)objekt).VypocitejObsah());

       
    }   
}




