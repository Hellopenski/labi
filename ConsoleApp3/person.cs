using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        public string name;
        public string familia;
        public DateTime dateofbirth;
        public Education education;
        Student[] myArray = new Student[5];

        public Person()
        {
            name = "Danya";
            familia = "Poltavskii";
            dateofbirth = new DateTime(2002, 04, 18);
        } 

        public string GetName()
        {
            return name;
        }
        
        public void SetName(string value)
        {
            name = value;
        }

        public string GetFamilia()
        {
            return familia;
        }
        public void SetFamilia(string value)
        {
            familia = value;
        }
        public DateTime Getdateofbirth()
        {
            return  dateofbirth;
        }
        public void Setdateofbirth(DateTime value)
        {
            dateofbirth = value;
        }

    }
}
