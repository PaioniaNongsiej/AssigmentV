using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.strlen();
            p.strrev();
            p.strcompare();
            Assigment2Part2 acc = new Assigment2Part2();
            acc.Show();
            Console.ReadLine();
        }

        //finds length of the sring
        public void strlen()
        {
            string str;
            int l = 0;

            Console.Write("Q1. length of a strings \n");
            Console.Write("__________________________________________________\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char ch in str)
            {
                l += 1;

            }
            Console.Write("\n\n");
            Console.Write("Length of the string is : {0}\n", l);
        }

        //reverse of a string
        public void strrev()
        {
            string Str, rev = "";
            int Length;
            Console.Write("__________________________________________________\n");
            Console.Write("Q2. reverse of a string \n");
            Console.Write("__________________________________________________\n");
            Console.Write("Enter A String: ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                rev = rev + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String::  {0} \t", rev);
            Console.ReadLine();
        }

        //compare a string
        public void strcompare()
        {
            string str1, str2;
            Console.Write("__________________________________________________\n");
            Console.Write("Q3. comparison of two strings \n");
            Console.Write("__________________________________________________\n");
            Console.WriteLine("Enter the First word");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the Another word");
            str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("Same word");
            }
            else
                Console.WriteLine("Not Same");
        }
    }
}
