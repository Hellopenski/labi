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

            student1.dannie_studenta = person1;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.familia);
            Console.WriteLine(person1.dateofbirth);
            Console.WriteLine(person1.education);
        }
    }
}
