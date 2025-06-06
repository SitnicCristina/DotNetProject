namespace DotNetExamples;

public class BankAccount
{
    private DateTime dataCrearii;
    private Persoana persoanaAsignata;
    private double nrCont;
    private string moneda;
    private string pin;
    // Istoricul tranzacțiilor trebuie să fie stocat -> salvam in lista
    private List<Tranzactie> tranzactii = new List<Tranzactie>();

    public BankAccount(DateTime dataCrearii, Persoana persoanaAsignata, double nrCont, string moneda, string pin)
    {
        this.dataCrearii = dataCrearii;
        this.persoanaAsignata = persoanaAsignata;
        this.nrCont = nrCont;
        this.moneda = moneda;
        this.pin = pin;
    }

    public double DetarminaSold()
    {
        double total = 0;
        foreach (var t in tranzactii) total += t.suma;
        return total;
    }

    public void AlimentareCont(double suma)
    {
        tranzactii.Add(new Tranzactie(suma, "Alimentare"));
    }

    public void ExtrageFond(double suma)
    {
        tranzactii.Add(new Tranzactie(-suma, "Extragere"));
    }

    public double CalculareSold()
    {
        double total = 0;
        foreach (var t in tranzactii) total += t.suma;
        return total;
    }
    
    public void AfiseazaInformatiiCont()
    {
        Console.WriteLine($"\nPersoana: {persoanaAsignata}");

        Console.WriteLine("Tranzactii:");
        foreach (Tranzactie t in tranzactii)
        {
            Console.WriteLine($"{t.tip} - {t.suma}");
        }
        
        Console.WriteLine($"Sold curent: {CalculareSold()} {moneda}");
    }

}