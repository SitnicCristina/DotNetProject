using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExamples
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            #region Filtrarea și Procesarea Unor Obiecte Diverse
            object[] obiecteMixte =
            {
               42,                                // întreg  
               "Salut!",                          // șir de caractere  
               new Student("Ioana", 21, "Biologie", 2) // obiect personalizat  
            };

            foreach (object obiectulMeu in obiecteMixte)
            {
                switch (obiectulMeu)
                {
                    case int:
                        if ((int)obiectulMeu % 2 == 0)
                        {
                            Console.WriteLine("Număr par: {0}", obiectulMeu);
                        }
                        else
                        {
                            Console.WriteLine("Număr impar: {0}", obiectulMeu);
                        }
                        break;
                    case string:
                        if (obiectulMeu.ToString().Length > 5)
                        {
                            Console.WriteLine("Sir lung: {0}", obiectulMeu);
                        }
                        else
                        {
                            Console.WriteLine("Sir scurt: {0}", obiectulMeu);
                        }
                        break;
                    default:
                        Console.WriteLine("Obiect necunoscut: {0}", obiectulMeu);
                        break;
                }
            }
            #endregion


            #region Evaluarea calificativului studenților:
            Console.WriteLine("Introdu nota ta de la test: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota == 10)
            {
                Console.WriteLine("Excelent");
            }
            else if (nota is >= 8 and <= 9)
            {
                Console.WriteLine("Bun");
            }
            else if (nota is >= 5 and <= 7)
            {
                Console.WriteLine("Suficient");
            }
            else if (nota is >= 1 and <= 4)
            {
                Console.WriteLine("Necalificat");
            }
            else
            {
                Console.WriteLine("Introdu o nota intre 10 si 1");
            }

            #endregion Construiți un program simplu de gestionare a meniului unui restaurant. 


            #region Construiți un program simplu de gestionare a meniului unui restaurant. 
            Console.WriteLine("Introduceti optiune din meniu: ");
            int nrOrdineOptiuneMeniu = int.Parse(Console.ReadLine());

            switch (nrOrdineOptiuneMeniu)   
            {
                case 1:
                    Console.WriteLine((Meniu)nrOrdineOptiuneMeniu);
                    break;
                case 2:
                    Console.WriteLine((Meniu)nrOrdineOptiuneMeniu);
                    break;
                case 3:
                    Console.WriteLine((Meniu)nrOrdineOptiuneMeniu);
                    break;
                case 4:
                    Console.WriteLine((Meniu)nrOrdineOptiuneMeniu);
                    break;
                default:
                    Console.WriteLine("Introduceti maximum optiunea 4");
                    break;
            }
            #endregion
        }

    }

    enum Meniu
    {
        Supa = 1,
        SalataCaesar = 2,
        SalataGreceasca =3,
        Inghetata = 4
    }
}
