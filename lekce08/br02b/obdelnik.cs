namespace br02;
 
public class Obdelnik : Tvar, IComparable
{
    private int _sirka;
    private int _vyska;
    public int Sirka {get {return _sirka;} set {this._sirka = value;}}
    public int Vyska {get {return _vyska;} set {this._vyska = value;}}

    public Obdelnik()
    {
        this._sirka = 1;
        this._vyska = 1;
    }

    public Obdelnik(int sirka, int vyska)
    {
        this._sirka = sirka;
        this._vyska = vyska;
    }

    public override double VypocitejObsah()
    {
        return this.Sirka * this.Vyska;
    }

    public override double VypocitejObvod()
    {
        return this.Sirka + this.Vyska + this.Sirka + this.Vyska;
    }

    public int CompareTo(object obj)
    {        
        Obdelnik tenDruhyObdelnik = (Obdelnik?)obj;
        //Porovnání mezi touto instancí objektu a tou druhou se kterou porovnávám. To kdy se vrací 1/0/-1 je "standard" 
        //Konkrétní logika jak svoje vlastní třídy budu porovnávat je ale na mě - já se rozhodl srovnávat je podle obsahu 
        if (this.VypocitejObsah() > tenDruhyObdelnik.VypocitejObsah())
            return 1;
        else if (this.VypocitejObsah() == tenDruhyObdelnik.VypocitejObsah())
            return 0;
        else
            return -1;
    }
}