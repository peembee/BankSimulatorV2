using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class Customer : User
    {
        public string Password { get; set; }
        public int IdNumber { get; set; }

        public int bankLoan = 0;
        public bool lockedOut = false;
        public bool debtToBank = false;
        public string adress;
        public double wallet;

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

        List<BankAccount> BankAcc = new List<BankAccount>();
        List<SavingAccount> SaveAcc = new List<SavingAccount>();



        public void AddNewBankAccount()
        {
            string accountName = "";
            int accountNumber;
            double balance;
            Console.Clear();
            Console.Write("Account name: ");
            accountName = Console.ReadLine();
            Console.Clear();
            Console.Write("Account number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine);
            Console.Clear();
            Console.Write("Account balance: ");
            balance = Convert.ToInt32(Console.ReadLine);
            Console.Clear();
            Console.WriteLine("New account has been added");
            BankAcc.Add(new BankAccount(accountName, accountNumber, balance));
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

        }
        public override string ToString()
        {
            return Name + ". " + Age + " Old" + "\nAdress: " + adress + "\nID: " + id + "\nPassword: " + password;
        }
    }
}
