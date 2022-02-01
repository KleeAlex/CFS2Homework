using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.FirstName = "Alex";
            s1.LastName = "Klee";
            s1.Id = "AGK1043";
            s1.Gpa = Convert.ToSingle("3.1");

            Console.WriteLine("Mr. {0} {1}, is a middeling student who's gpa sits at {2} ID for the year is {3}", s1.FirstName, s1.LastName, s1.Gpa, s1.Id);

        }
    }
}
