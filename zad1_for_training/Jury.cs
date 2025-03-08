using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_for_training
{
    internal class Jury
    {
        private List<Student> competitors;

        public Jury(List<Student> students)
        {
            this.competitors = students;
        }

        public void FindStudent(int difference)
        {
            Sort();
            int target = competitors[0].Result + difference;
            int result = BinarySearch(competitors, target);
            if (result != -1)
            {
                Console.WriteLine("\nStudent found: ");
                Console.WriteLine(competitors[result]);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No such student found.");
            }
        }
        private void Sort()
        {
            
        }

        

        private int BinarySearch(List<Student> list, int target)
        {
            
        }
    }
}
