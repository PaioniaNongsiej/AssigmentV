using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dayscholar ds = new Dayscholar();
            ds.ShowDetails();
            Console.WriteLine("\n________________\n");
            Resident rd = new Resident();
            rd.ShowDetails();
            Console.Read();
        }
        public interface IStudent
        {
            int StudentId { get; set; }
            string Name { get; set; }
            void ShowDetails();
        }

        public class Dayscholar : IStudent
        {
            public int StudentId { get; set; } = 1 ;
            public string Name { get; set; } = "Paionia Nongsiej";
            public float Fees { get; set; } = 50000;

            public void ShowDetails()
            {
                Console.WriteLine($"Student ID: {StudentId}\nName: {Name}\nFees: {Fees}");
            }
        }

        public class Resident : IStudent
        {
            public int StudentId { get; set; } = 2;
            public string Name { get; set; } = "Elizabeth L. Mawphlang";
            public float Fees { get; set; } = 100000;

            public void ShowDetails()
            {
                Console.WriteLine($"Student ID: {StudentId}\nName: {Name}\nFees: {Fees}");
                Console.ReadLine();
            }
        }
    }
}

