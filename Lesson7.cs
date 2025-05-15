using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExamples
{
    internal class Lesson7
    {
        static void Main(string[] args)
        {

            #region
            //Console.WriteLine("Introduceti numarul de studenti: ");
            //int nrStudenti = int.Parse(Console.ReadLine());

            //for (int i = 0; i < nrStudenti; i++)
            //{
            //    Console.WriteLine("Introduceti notele elevului {0} prin spatiu: ", i + 1);
            //    string note = Console.ReadLine();

            //    var splitArray = note.Split(" ");
            //    int[] array = Array.ConvertAll(splitArray, int.Parse);

            //    Console.WriteLine($"Media notelor {array.Average()}\n");
            //}
            #endregion

            #region
            DateAngajati[] angajati = new DateAngajati[3];
            double sum = 0;

            for (int i = 0; i < angajati.Length; i++)
            { 
                Console.WriteLine($"Introduceti datele la angajatul : {i + 1}: ");
                Console.Write("Nme: ");
                angajati[i].name = Console.ReadLine();

                Console.Write("Departament: ");
                angajati[i].depart = Console.ReadLine();

                Console.Write("Salary: ");
                angajati[i].salary = double.Parse(Console.ReadLine());

                sum += angajati[i].salary;
                
            }

            Console.WriteLine("\nMedia salariului este {0} ", sum / 3);
            #endregion

        }
    }

    struct DateAngajati
    {
        public string name;
        public string depart;
        public double salary;
    }
}
