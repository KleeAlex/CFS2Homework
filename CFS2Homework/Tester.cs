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

            Login l1 = new Login();
            l1.UserName = "AGKfadsljk";
            l1.Password = "654fsda";

            Console.WriteLine("Your temporary Username, and Password are as follows.\nUsername: {0}\nPassword: {1}", l1.UserName, l1.Password);

            Console.WriteLine("\n\n");

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "503 Made Up Lane";
            c1.City = "Smallville";
            c1.State = "Missouri";
            c1.Zip = "64099";
            c1.Phone = "816-895-5555";
            c1.Email = "veryrealemail@email.com";

            Console.WriteLine("Let's verify all of your contact info before you leave for the day." +
                "\nYou live at {0}, {1}, {2}, {3}." +
                "\nand your phone number, and email are {4}, {5}", c1.StreetAddress, c1.City, c1.State, c1.Zip, c1.Phone, c1.Email);































        }
    }
}
