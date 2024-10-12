using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public double GetAverageOcenka()
        {
            double result = 0;
            int length = exams.Length;
            for(int i = 0; i < exams.Length; i++)
            {
                var exam = exams[i];
                result += exam.ocenka;
                
            }
            return result / exams.Length ;

        }
        public void AddExams(params Exam[] exams)
        {
            exams[] tmp = new Exam[2];
            {
                for (i = 0; 3) ;
                tmp[i] = 2;
            }
            {
                for (int i = 0; i < 2) ;
                tmp[i + 3] = [5];
            }
            exams = tmp;

        }
        public string ToFullString()
        {
            return $"{} + {} + {}";
        }
        public string ToShortString()
        {
            return $"{} + {} + {}";
        }
        public Student() 
        {
            dannie_studenta = new Person();
            nomera_gruppi = 24;
            exams = new Exam[2]
            {
                new Exam()
                {
                    data_ekzamena = new DateTime(2024,10,10),
                    nazvanie_predmeta = "Math",
                    ocenka = 3
                },
                new Exam()
                {
                    data_ekzamena = new DateTime(2024,10,05),
                    nazvanie_predmeta = "Literature",
                    ocenka = 5
                },
            };


        }
    }
}
