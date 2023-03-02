using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scholarship scholarship = new Scholarship(100, 25000.0f);
            float scholarshipAmount = scholarship.Merit(85, scholarship.Fees);
            Console.WriteLine("Scholarship Amount: " + scholarshipAmount);
            Console.Read();
        }
        public class Scholarship
        {
            private int TotalMarks;
            public float Fees;

            public Scholarship(int totalMarks, float fees)
            {
                this.TotalMarks = totalMarks;
                this.Fees = fees;
            }

            public float Merit(int m, float f)
            {
                float scholarshipAmount = 0.0f;
                if (m >= 70 && m <= 80)
                {
                    scholarshipAmount = 0.2f * f;
                }
                else if (m > 80 && m <= 90)
                {
                    scholarshipAmount = 0.3f * f;
                }
                else if (m > 90)
                {
                    scholarshipAmount = 0.5f * f;
                }
                return scholarshipAmount;
            }
        }
    }
}
