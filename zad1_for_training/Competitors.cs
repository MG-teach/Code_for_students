using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_for_training
{
    internal class Competitors
    {
        public Competitors()
        {
            Students = StudentCreator.CreateStudents(20);
        }

        public List<Student> Students { get; set; }
    }
}
