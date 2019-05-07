using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Udin",24);
            person.PrintNameAge();

            Teacher teacher = new Teacher("Mulyadi", 45,"3492JC", "Matematika");
            teacher.PrintNameAge();

            Student student = new Student("Aldi",15,"2279","aldididi@gmail.com");
            student.PrintNameAge();

            Console.ReadKey();
        }
    }
}
