namespace br02;


public class Kruh : Tvar
{        
    private int _polomer;
    public int Polomer {get {return _polomer;} set {this._polomer = value;}}    

    public Kruh()
    {
        this._polomer = 1;        
    }
    public Kruh(int polomer)
    {
        this._polomer = polomer;        
    }

    public override double VypocitejObsah()
    {
        return Math.PI * this._polomer * this._polomer;
    }

    public override double VypocitejObvod()
    {
        return 2 * Math.PI * this._polomer;
    }
}