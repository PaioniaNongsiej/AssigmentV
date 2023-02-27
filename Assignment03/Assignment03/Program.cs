using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
            static void Main(string[] args)
            {
                int count = 0;

                Console.Write("program to display first name and last name to uppercase\n");
                Console.Write("___________________________________________________________\n");
                Console.Write("Enter your first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();

                Display(firstName, lastName);

                Console.Write("___________________________________________________________\n");
                Console.Write("program to display number of occurance of a letter\n");
                Console.Write("___________________________________________________________\n");

                Console.Write("Enter a string: \n");
                string str = Console.ReadLine();
                Console.Write("Enter the letter to count: ");
                char letter = char.Parse(Console.ReadLine());

                count = CountLetterOccurrences(str, letter);
                Console.WriteLine("The letter '{0}' appears {1} times in the string '{2}'.", letter, count, str);

                Console.Read();
            }
            static void Display(string firstName, string lastName)
            {
                Console.WriteLine(firstName.ToUpper());
                Console.WriteLine(lastName.ToUpper());
                Console.Read();
            }

            static int CountLetterOccurrences(string str, char letter)
            {
                int count = 0;
                foreach (char c in str)
                {
                    if (c == letter)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
