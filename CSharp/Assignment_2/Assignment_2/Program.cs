﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.strcompare();
            p.strlen();
            p.strrev();
            Console.ReadLine();
            Accounts obj = new Accounts();
            obj.Show();
            Console.ReadLine();
        }
        public void strlen()
        {
            string str;
            int l = 0;

            Console.Write("\n C# to accept a word from the user and display the length :\n");
            Console.Write("**************************************\n");
            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }
            Console.Write("**************************************\n");
            Console.Write("The Lenght of the string is : {0}\n\n", l);
            Console.Write("**************************************\n");
        }

        public void strrev()
        {
            string Str, rev = "";
            int Length;
            Console.Write("Enter A String :: ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                rev = rev + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse String Is::  {0} \t", rev);
            Console.ReadLine();
        }

        public void strcompare()
        {
            string str1, str2;
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
    internal class Accounts
    {
        public int ACCOUNTno;
        public string CustomerName;
        public string AccountType;
        public string TransactionType;
        public double amount;
        public double balance = 1000;

        public void Show()
        {
            Console.WriteLine("Input the Account Number:");
            this.ACCOUNTno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer's Name:");
            this.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the Account Type:");
            this.AccountType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
            this.TransactionType = Console.ReadLine();
            Console.WriteLine("Enter the total Amount:");
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
            Console.WriteLine($"Account Number: {ACCOUNTno}  Customer's Name: {CustomerName} Account Type: {AccountType} Tansaction Type: {TransactionType} Amount: {amount} Remaining Balance: {balance}");
        }
    }
}