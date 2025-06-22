namespace DotNetExamples.Lesson17_2;

public class Carte
{
    private string Titlu { get; set; }
    private string Autor { get; set; }
    private int NumarPagini { get; set; }
    private DateTime AnPublicare { get; set; }
    
    public Carte(string titlu, string autor, int numarPagini, int anPublicare)
    {
        Titlu = titlu;
        Autor = autor;
        NumarPagini = numarPagini;
        AnPublicare = new DateTime(anPublicare, 1, 1);;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Cartea: {Titlu} + ' ' + {Autor} + ' ' + {NumarPagini} + ' ' + {AnPublicare.Year}");
    }
    
}