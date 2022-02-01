using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Students
    {


        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }


        public Students(string firstName, string lastName, string id , float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        public Students() { }

        public override string ToString()
        {
            return string.Format("FirstName: {0}\nLastName: {1}\nId: {2}\nGpa: {3}", FirstName, LastName, Id, Gpa);
        }






    }
}
