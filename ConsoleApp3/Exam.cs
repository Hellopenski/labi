using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Exam
    {
        public string nazvanie_predmeta;
        public int ocenka;
        public DateTime data_ekzamena;

        public Exam() 
        {
            nazvanie_predmeta = "MATAN";
            ocenka = 5;
            data_ekzamena = new DateTime(2024, 12, 27);
        }
    }
}
