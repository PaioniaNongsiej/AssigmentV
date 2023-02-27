using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Paionia Nongsiej", "MCA", 4, "computer science");
            s.DisplayData();
            s.GetMarks();
            s.DisplayResult();
        }

        public class Student
        {
            private int rollno;
            private string name;
            private string Sclass;
            private int semester;
            private string branch;
            private int[] marks = new int[5];

            public Student(int rollno, string name, string Sclass, int semester, string branch)
            {
                this.rollno = rollno;
                this.name = name;
                this.Sclass = Sclass;
                this.semester = semester;
                this.branch = branch;
            }

            public void GetMarks()
            {
                Console.WriteLine("Enter the marks for {0}:", name);
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write("Subject {0}: ", i+1);
                    marks[i] = int.Parse(Console.ReadLine());
                }
                Console.ReadLine();
            }

            public void DisplayResult()
            {
                int sum = 0;
                foreach (int mark in marks)
                {
                    sum += mark;
                    if (mark < 35)
                    {
                        Console.WriteLine("Result: Failed");
                        return;
                    }
                }

                double average = sum / (double)marks.Length;

                if (average < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }

            public void DisplayData()
            {
                Console.WriteLine("Roll No: {0}", rollno);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Class: {0}", Sclass);
                Console.WriteLine("Semester: {0}", semester);
                Console.WriteLine("Branch: {0}", branch);
                Console.WriteLine("Marks:");
            }
        }
    }
}
