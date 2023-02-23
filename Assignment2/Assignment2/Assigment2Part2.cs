using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Assigment2Part2
    {
        public int AccNo;
        public string CName;
        public string AccType;
        public string TransactionType;
        public double amount;
        public double balance = 5000;

        public void Show()
        {
            Console.Write("\n__________________________________________________\n");
            Console.Write("assignment2, part 2\nprogram to show account details\n");
            Console.Write("__________________________________________________\n");

            Console.WriteLine("Enter Account Number:");
            this.AccNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer's Name:");
            this.CName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            this.AccType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
            this.TransactionType = Console.ReadLine();
            Console.WriteLine("Enter Amount:");
            this.amount = Convert.ToDouble(Console.ReadLine());
            if (TransactionType == "d")
            {
                TransactionType = "Deposit";
                balance = balance + amount;
            }
            else if (TransactionType == "w" && amount < balance)
            {
                TransactionType = "Withdrawal";
                balance = balance - amount;
            }
            else if (TransactionType == "w" && amount > balance)
            {
                TransactionType = "Transaction is not possible.";
            }
            Console.WriteLine($"\nAccount Number: { AccNo} \nCustomer's Name: {CName} \nAccount Type: {AccType} \nTansaction Type: { TransactionType} \nAmount: { amount} \nRemaining Balance: { balance}");
        }
    }
}
