using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Q1();
            p.Q2();
            Console.ReadLine();
        }
        public void Q1()
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n;
            float sum = 0, avg = 0;

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sum and average of the elements
            for (i = 0; i < n; i++)
            {
                sum += arr1[i];
            }
            avg = sum / n;
            Console.Write("Sum {0} \n ", sum);
            Console.Write("Average {0} \n ", avg);

            mx = arr1[0];
            mn = arr1[0];

            //maximum and minimum element
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
        }

        //question number 2
        public void Q2()
        {
            int[] arr1 = new int[100];
            int i, mx, mn;
            float sum = 0, avg = 0;

            Console.Write("Input marks of the student in 10 sujects:\n");
            for (i = 0; i <= 10; i++)
            {
                Console.Write("Mark- {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i <= 10; i++)
            {
                sum += arr1[i];
            }
            avg = sum / 10;

            Console.Write("total Marks {0} \n ", sum);
            Console.Write("Average of Marks  {0} \n ", avg);

            mx = arr1[0];
            mn = arr1[0];


            for (i = 1; i <= 10; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }

            Console.Write("Maximum Marks is : {0}\n", mx);
            Console.Write("Minimum Marks  is : {0}\n\n", mn);

            //sorting of the marks
            Array.Sort(arr1);
            Console.WriteLine("the marks in Ascending order : ");

            foreach (int val in arr1)
            {
                Console.Write(val + " ");
            }

            Array.Reverse(arr1);
            Console.WriteLine("\n the marks in Desending order : ");

            foreach (int val in arr1)
            {
                Console.Write(val + " ");
            }


        }
    }
}
