using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Person person1 = new Person();
            person1.name = "Daniil";
            person1.familia = "Poltavskii";
            person1.dateofbirth = new DateTime(2002,04,18);
            person1.education = Education.Specialist;

            Student student1 = new Student();

            
            string daniie = student1.ToShortString();
            string dannie1 = student1.ToFullString();



            Exam exams = new Exam();
            exams.nazvanie_predmeta = "Math";
            exams.nazvanie_predmeta = "History";

            student1.AddExams(new Exam("Math", 4, new DateTime(2024, 10, 10)), new Exam("C#", 5, new DateTime(2024, 10, 11)));

            Console.WriteLine("average grade: " + student1.GetAverageOcenka());

            return;

            student1.dannie_studenta = person1;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.familia);
            Console.WriteLine(person1.dateofbirth);
            Console.WriteLine(person1.education);




        }
    }
}
