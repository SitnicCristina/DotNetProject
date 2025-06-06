namespace DotNetExamples;

public class Tranzactie
{
    public double suma;
    public string tip; // "Alimentare" sau "Retragere"

    public Tranzactie(double suma, string tip)
    {
        this.suma = suma;
        this.tip = tip;
    }
}
