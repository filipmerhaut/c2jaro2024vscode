namespace br02;
public class Clovek
{
	public string Jmeno {get; set;}
	public string Prijmeni {get; set;}
	public int TelCislo {get; set;}
	
    public Clovek()
    {
        
    }

	public Clovek(string jmeno, string prijmeni, int telCislo)
	{
		Jmeno = jmeno;
		Prijmeni = prijmeni;
		TelCislo = telCislo;
	}
}