namespace DotNetExamples;

public class Persoana
{
    public string cif;
    public double idnp;

    // Constructor for persoana juridica (CIF)
    public Persoana(string cif)
    {
        this.cif = cif;
    }

    // Constructor for persoana fizica (IDNP)
    public Persoana(double idnp)
    {
        this.idnp = idnp;
    }
    
    public override string ToString()
    {
        if (cif != null)
            return $"Persoana juridica – CIF: {cif}";
        else
            return $"Persoana fizica – IDNP: {idnp}";
    }
    
    
}
