namespace DotNetExamples;

public class Lesson9
{
    // private static void Main(string[] args)
    // {
        // #region Ex1. Calcularea mediei unui set de note
        //
        // int[] note = new int[4];
        // double media = 0;
        // double suma = 0;
        // try
        // {
        //     for (int i = 0; i < 4; i++)
        //     {
        //         Console.Write($"Introduceti nota {i + 1}: ");
        //         note[i] = int.Parse(Console.ReadLine());
        //         if (note[i] < 0)
        //         {
        //             throw new NegativeValueEntered("Valoarea introdusa este negativa!");
        //         }
        //         suma += note[i];
        //     }
        // }
        // catch (FormatException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // catch (NegativeValueEntered e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        //
        // Console.WriteLine($"Media notelor este: {suma / note.Length}");
        // #endregion

    //     #region Ex2. Validarea datelor de autentificare
    //
    //     Utilizator utilizator = new Utilizator();
    //     Console.Write("Introduceti nume de utilizator: ");
    //     try
    //     {
    //         utilizator.nume = Console.ReadLine();
    //         if (utilizator.nume == null)
    //         {
    //             throw new NumeUtiliceptiozatorGolException("Nume Utilizator este Gol!");
    //         }
    //     }
    //     catch (NumeUtiliceptiozatorGolException e)
    //     {
    //         Console.WriteLine(e);
    //     }
    //
    //
    //     Console.Write("Introduceti porola: ");
    //     try
    //     {
    //         utilizator.parola = Console.ReadLine();
    //         if (utilizator.parola.Length < 6)
    //         {
    //             throw new ParolaPreaScurtaException("Parola este prea scurta");
    //         }
    //     }
    //     catch (ParolaPreaScurtaException e)
    //     {
    //         Console.WriteLine(e);
    //     }
    //
    //     #endregion
    // }

    struct Utilizator()
    {
        public string nume;
        public string parola;

        public Utilizator(string nume, string parola) : this()
        {
            this.nume = nume;
            this.parola = parola;
        }
    }
}

class NegativeValueEntered : Exception
{
    public NegativeValueEntered(string message) : base(message)
    {
    }
}

class NumeUtiliceptiozatorGolException : Exception
{
    public NumeUtiliceptiozatorGolException(string message) : base(message)
    {
    }
}

class ParolaPreaScurtaException : Exception
{
    public ParolaPreaScurtaException(string message) : base(message)
    {
    }
}

class ParolaInvalidaException : Exception
{
    public ParolaInvalidaException(string message) : base(message)
    {
    }
}

class CredentialeInvalideExn : Exception
{
    public CredentialeInvalideExn(string message) : base(message)
    {
    }
}