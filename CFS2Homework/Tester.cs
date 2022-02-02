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

            Console.WriteLine("\n\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "Nissan";
            v1.Model = "Quest";
            v1.Year = Convert.ToInt16("2009");
            v1.Weight = Convert.ToSingle("8000");

            Console.WriteLine("The brand new {0} {1} {2}, coming in at only {3} pounds!!!", v1.Year, v1.Make, v1.Model, v1.Weight);

            Console.WriteLine("\n\n");



































        }
    }
}
