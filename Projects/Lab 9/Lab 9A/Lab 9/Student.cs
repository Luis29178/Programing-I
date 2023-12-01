using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
     public class Student
    {
        
        // Add member fields here

        private string lName;
        private string fName;
        private int idNo;
        // Add default and overloaded constructors here

         public Student(string x, string y, int z)
        {
            lName = x;
            fName = y;
            idNo = z;
        }
        public Student()
        {
            lName = "";
            fName = "";
            idNo = 1000000;
        }
        // add Getters and Setters here
        public string GetFirstName()
        {
            return fName;
        }
        public string GetLastName()
        {
            return lName;
        }
        public int GetIDNumber()
        {
            return idNo;
        }
        public string SetFirstName(string y)
        {
            fName = y;
            return y;
        }
        public string SetLastName(string x)
        {
            lName = x;
            return x;
        }
        public int SetIDNumber(int z)
        {
            idNo = z;
            return z;
        }

        // do not modify any of the following code
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + 
                                                   ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (lName != s2.GetLastName() || fName != s2.GetFirstName() || idNo != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

