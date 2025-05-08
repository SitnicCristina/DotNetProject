using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExamples
{
    /*
     Definiți o structură pentru a reprezenta informațiile despre un student (nume, vârstă, specializare, anul de studii).
     Solicitați utilizatorului să introducă informațiile despre un student de la tastatură.
     Utilizați enumerațiile pentru a indica anul de studii. Valori admisibile: I, II, III, IV, V, VI.
     Utilizați structura pentru a stoca aceste informații și pentru a le accesa ulterior.
     Afișați informațiile despre student la ecran.
            */
    internal class Student
    {
        string name;
        int age;
        string speciality;
        int studyGrade;

        public Student(string name, int age, string speciality, int studyGrade)
        {
            this.name = name;
            this.age = age;
            this.speciality = speciality;
            this.studyGrade = studyGrade;
        }

        enum YearGrade
        {
            I = 1,
            II = 2,
            III = 3,
            IV = 4,
            V = 5,
            VI = 6
        }

        public void DisplayStudentDetails() 
        {
            if (Enum.IsDefined(typeof(YearGrade), studyGrade))
            {
                Console.WriteLine($"\nStudent Details:\n Name: {name} \n Age: {age} \n Speciality: {speciality} \n Study Grade: {(YearGrade)studyGrade}");
            }
            else
            {
                Console.WriteLine("\nInvalid study grade.");
            }
        }



    }
}
