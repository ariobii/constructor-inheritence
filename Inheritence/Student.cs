using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student(string nama, int umur, string id, string email) : base(nama, umur)
        {
            StudentId = id;
            Email = email;
        }
    }
}
