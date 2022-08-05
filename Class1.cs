using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExamples
{
    public abstract class School
    {
        public abstract void Department(int noOfDept);
        public abstract void Lecturers();
        public void Dummy()
        {
            Console.WriteLine("A normal method which is not abstract so does not need to be overridden");
        }
    }
    public class SchoolInfo : School
    {
        public override void Department( int noOfDept)
        {
            Console.WriteLine("What is your School Name? ");
            string schoolName = Console.ReadLine();
            Console.WriteLine("What is your Faculty's Name? ");
            string faculty = Console.ReadLine();
            //Have a database or dictionary to extract number of departments based
            //on faculty and school name
            //string schoolName = Console.ReadLine();
            Console.WriteLine("{0} has {1} departments in the {2} faculty",schoolName, noOfDept,faculty);
        }
        public override void Lecturers()
        {
            Console.WriteLine("What is your School Name? ");
            string schoolName = Console.ReadLine();
            Console.WriteLine("What is your departments Name? ");
            string deptName = Console.ReadLine();
            Console.WriteLine("What is your Name? ");
            string lecturerName = Console.ReadLine();
            Console.WriteLine("{0} is a lecturer of {1} in {2}", lecturerName, deptName,schoolName);
        }
        
    }
    class InterfaceSample: IIntegerCalc
    {
        public int IntegerProperty { get; set; }
        public string MethodConc(string a, string b) 
        {
            return a + b;
        }
        public int MethodAddition(int a, int b)
        {
            return a + b; 
        }
    }
}
