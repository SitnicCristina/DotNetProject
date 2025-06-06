namespace DotNetExamples;

public class Angajat
{
    public string nume;
    public double salariu;
    public string departament;


    public Angajat(string nume, double salariu, string departament)
    {
        this.nume = nume;
        this.salariu = salariu;
        this.departament = departament;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"{nume} {salariu} {departament}");
    }

}