﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class Customer : User
    {
        public int bankLoan = 0;
        public bool debtToBank = false;
        public string adress;
        public double wallet;
        private bool lockedOut = false;
        private int passwordTries = 3;
       
        public bool LockedOut
        {
            get
            {
                return lockedOut;
            }
            set
            {
                lockedOut = value;
            }
        }
        public string Password
        {
            get
            { return password;}
            set
            { password = value; }
        }
        public int IdNumber
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private List<BankAccount> bankAccList = new List<BankAccount>();
        private List<SavingAccount> saveAccList = new List<SavingAccount>();
        public Customer(string Name, string adress, int Age, int idNumber, string password, double wallet)
        {
            this.Name = Name;
            this.adress = adress;
            this.Age = Age;
            this.id = idNumber;
            this.password = password;
            this.wallet = wallet;
            IsAdmin = false;
        }
        public int PasswordTries(bool readPasswordTries = false) // this function will be called when user entered wrong password. Password decreases with 1. then getting locked. : Or just read value of passwordTries
        {
            if (readPasswordTries == false)
            {
                passwordTries--;
            }
            if (passwordTries <= 0)
            {
                passwordTries = 0;
                lockedOut = true;
            }
            return passwordTries;
        }
        public void AddNewBankAccount()
        {
            string accountName = "";
            int accountNumber = 0;
            double balance = 0;
            Console.Clear();
            Console.Write("Account name: ");
            accountName = Console.ReadLine();
            Console.Clear();
            Console.Write("Account number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Account balance: ");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("New account has been added");
            bankAccList.Add(new BankAccount(accountName, accountNumber, balance));
            System.Threading.Thread.Sleep(1000);


        }
        public void AddSavingAccount()
        {

        }
        public void AddLoan()
        {

        }
        public void DisplaySaveAccount()
        {

        }
        public void DisplayBankLoan()
        {

        }
        public void AllTransactionOnCustomer()
        {

        }
        public void DisplayAllBankAccount()
        {
            Console.Clear();
            Console.WriteLine("Bank-Accounts");
            foreach (var bankAccount in bankAccList)
            {                
                Console.WriteLine(bankAccount);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("\nSaving-Accounts");
            foreach (var saveAccounts in saveAccList)
            {
                Console.WriteLine(saveAccounts);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Key for menu..");
            Console.ReadKey();
        }
        public override string ToString()
        {
            return Name + ". " + Age + " Old" + "\nAdress: " + adress + "\nID: " + id + "\nPassword: " + password;
        }
    }
}
