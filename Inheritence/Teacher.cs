using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string nama, int umur, string id, string mapel) : base(nama, umur)
        {
            TeacherId = id;
            Subject = mapel;
        }
    }
}
