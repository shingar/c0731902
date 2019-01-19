using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731902
{
    class program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.5, 20);
            StudentInformation _John = new StudentInformation("John", 2.0, 10);
            StudentInformation _Mark = new StudentInformation("Mark", 0.2, 3);
            StudentInformation _Steve = new StudentInformation("Steve", 2.9, 16);
            StudentInformation _Cindy = new StudentInformation("Cindy", 2.8, 18);
            Console.ReadLine();
        }
    }
    class StudentInformation
    {
        public string Name;

        public double GPA;
        public int Attendance;
        public StudentInformation(string aName, double cGPA, int dAttendance)
        {
            Name = aName;

            GPA = cGPA;
            Attendance = dAttendance;
        }
    }
}