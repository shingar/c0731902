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
            StudentInformation Mary = new StudentInformation("Mary", 3.8, 20);

            StudentInformation John = new StudentInformation("John", 1.8, 2);

            StudentInformation Mark = new StudentInformation("Mark", 2.5, 3);

            StudentInformation Steve = new StudentInformation("Steve", 3.3, 18);

            StudentInformation Cindy = new StudentInformation("Cindy", 2.3, 12);





            var StudentList = new List<StudentInformation>();



            StudentList.Add(Mary);

            StudentList.Add(John);

            StudentList.Add(Mark);

            StudentList.Add(Steve);

            StudentList.Add(Cindy);



            foreach (var Student in StudentList)

            {

                Console.WriteLine(Student.Name);

            }

            Console.ReadLine();

        }



    }



    class StudentInformation

    {

        public string Name;



        public double GPA;

        public int Attn;



        public StudentInformation(string aName, double aGPA, int aAttn)

        {

            Name = aName;

            GPA = aGPA;

            Attn = aAttn;

        }



    }



    class StudentList

    {

        public void CICS()

        {

        }
    }
}