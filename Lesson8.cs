namespace DotNetExamples;

public class Lesson8
{
    private static void Main(string[] args)
    {
        #region Tema 1: Utilizare for
            Console.WriteLine("Introduceti un intervalului de numere pentru a verifica par/impar");
            Console.Write("Introduceti un număr de început: ");
            var nrDeInceput = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un număr de sfirsit: ");
            var nrDeSfirsit = int.Parse(Console.ReadLine());
            
            if (nrDeInceput < nrDeSfirsit)
            {
                for (var i = nrDeInceput; i <= nrDeSfirsit; i++)
                {
                    Console.Write(i % 2 == 0 ? $"Numarul {i} este par\n" : $"Numarul {i} este impar\n");
                }
            }
            else
            {
                Console.Write("Numarul de inceput trebuie sa fie mai mare ca cel de sfirsit.");
            }
        #endregion

        #region Tema 2: Utilizare while
            Console.Write("/nIntroduceti un numar pentru a verifica daca este 0:");
            var nrIntrodus = int.Parse(Console.ReadLine());
            
            while (nrIntrodus != 0)
            {
                Console.Write($"Numarul introdus {nrIntrodus} nu este 0 \nIntroduceti un alt numar: ");
                nrIntrodus = int.Parse(Console.ReadLine());
            }
        #endregion

        #region Tema 3: Utilizare foreach
            List<DatePersonale> toatePersoanele = new List<DatePersonale>();
            toatePersoanele.Add(new DatePersonale("Ana", 30, "Doctor"));
            toatePersoanele.Add(new DatePersonale("Ion", 26, "Inginer"));
            toatePersoanele.Add(new DatePersonale("Maria", 34, "Designer"));
            toatePersoanele.Add(new DatePersonale("Tom", 31, "Doctor"));

            // Utilizați o buclă foreach pentru a itera prin lista de persoane și a afișa informațiile despre fiecare persoană.
            foreach (var p in toatePersoanele)
            {
                Console.WriteLine($"Numele:{p.nume}, Virsta:{p.virsta}, Ocupatie:{p.ocupatie}" );
            }
            
            //Permiteți utilizatorului să introducă o ocupație de referință.
            Console.Write("\nIntroduceti o ocupatie de referinta: ");
            string ocupatieCautare = Console.ReadLine();

            foreach (var p in toatePersoanele)
            {
                if (ocupatieCautare.ToLower() == p.ocupatie.ToLower())
                {
                    Console.WriteLine($"Numele:{p.nume}, Virsta:{p.virsta}, Ocupatie:{p.ocupatie}" );
                }
            }
            
            
        
        #endregion

    }

    struct DatePersonale
    { 
        public string nume;
        public int virsta;
        public string ocupatie;

        public DatePersonale(string nume, int virsta, string ocupatie)
        {
            this.nume = nume;
            this.virsta = virsta;
            this.ocupatie = ocupatie;
        }
    }

    
}