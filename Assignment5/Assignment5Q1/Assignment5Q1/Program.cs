using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            undergraduate.Name = "Paionia Nongsiej";
            undergraduate.StudentId = 92345;
            undergraduate.Grade = 85.0;
            Console.WriteLine("{0} Undergraduate is Passed: {1}", undergraduate.Name ,undergraduate.IsPassed(undergraduate.Grade));

            Graduate graduate = new Graduate();
            graduate.Name = "Elizabeth L. Mawphlang";
            graduate.StudentId = 98900;
            graduate.Grade = 78.0;
            Console.WriteLine("{0} Graduate is Passed: {1}",graduate.Name, graduate.IsPassed(graduate.Grade));
            Console.Read();
        }
        public abstract class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

            public abstract bool IsPassed(double grade);
        }

        public class Undergraduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 70.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 80.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
