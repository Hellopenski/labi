using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
 class Student
    {
        public Person dannie_studenta;
        //private Education 
        public int nomera_gruppi;
        public Exam[] exams;

        public Student() 
        {
            dannie_studenta = new Person();
            nomera_gruppi = 24;
            exams = new Exam[5]; 


        }
    }
}
