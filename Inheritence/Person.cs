using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Person
    {
        public string Nama { get; set; }
        public int Age { get; set; }

        public Person(string nama, int umur)
        {
            Nama = nama;
            Age = umur;
        }

        public void PrintNameAge()
        {
            Console.WriteLine("This person has name : {0} and age : {1}", Nama, Age);
        }
    }
}
