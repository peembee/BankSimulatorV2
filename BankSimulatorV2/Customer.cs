using System;
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
            { return password; }
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
            string accountName = "";
            int accountNumber;
            double deposit;
            Console.Clear();
            Console.Write("Account name: ");
            accountName = Console.ReadLine();
            Console.Clear();
            Console.Write("Account number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Amount to deposit: ");
            deposit = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("The current interest rate will be 30%. Do you wish to continue? (Y/N)");
            var keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("New saving account has been added.");
                SaveAcc.Add(new SavingAccount(accountName, accountNumber, deposit));
                Console.WriteLine("");
            }
            else
            {
                return;
            }
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

        public void TransferMoneyBetweenBankAccounts()
        {
            string getAccount;
            string toAccount;
            double withdraw = 0;
            string balance = "";
            while (true)
            {
                bool breakLoop = false;
                Console.Clear();
                Console.WriteLine("--------------------------");
                foreach (var bankaccounts in bankAccList)
                {
                    Console.WriteLine(bankaccounts.BankAccountName);
                }
                Console.WriteLine("--------------------------");
                Console.Write("Which Bank-Account would you like withdraw from: ");
                getAccount = Console.ReadLine();
                getAccount = getAccount.Trim();
                getAccount = getAccount.ToLower();
                getAccount = char.ToUpper(getAccount[0]) + getAccount.Substring(1);
                foreach (var bankaccounts in bankAccList)
                {
                    if (getAccount == bankaccounts.BankAccountName)
                    {
                        breakLoop = true;
                        balance = bankaccounts.Balance.ToString();
                        break;
                    }
                }
                if (breakLoop == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Did not find the Account, try again..");
                    System.Threading.Thread.Sleep(1500);
                }
            }
            while (true)
            {
                Console.Clear();
                bool breakLoop = false;
                Console.WriteLine("--------------------------");
                foreach (var bankaccounts in bankAccList)
                {
                    Console.WriteLine(bankaccounts.BankAccountName);
                }
                Console.WriteLine("--------------------------");
                Console.Write("Which Bank-Account would you like to deposit to: ");
                toAccount = Console.ReadLine();
                toAccount = getAccount.Trim();
                toAccount = getAccount.ToLower();
                toAccount = char.ToUpper(toAccount[0]) + toAccount.Substring(1);
                foreach (var bankaccounts in bankAccList)
                {
                    if (toAccount == bankaccounts.BankAccountName)
                    {
                        breakLoop = true;
                        break;
                    }
                }
                if (breakLoop == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Did not find the Account, try again..");
                    System.Threading.Thread.Sleep(1500);
                }
            }
            while (true)
            {
                bool breakLoop = false;
                while (true)
                {
                    Console.WriteLine(getAccount + ": Balance: " + balance);
                    Console.Write("Enter amount to withdraw: ");
                    try
                    {
                        withdraw = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        // Do nothing
                    }
                }
                foreach (var bankAccounts in bankAccList)
                {
                    if (getAccount == bankAccounts.BankAccountName)
                    {
                        if (withdraw <= bankAccounts.Balance)
                        {
                            bankAccounts.Withdraw(withdraw);
                            foreach (var toBankAccounts in bankAccList)
                            {
                                if (toAccount == bankAccounts.BankAccountName)
                                {
                                    bankAccounts.GetMoney(withdraw);
                                }
                            }
                            breakLoop = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You can't withdraw more than you have in " + bankAccounts.BankAccountName + ", Try again");
                        }
                    }
                }
                if (breakLoop == true)
                {
                    break;
                }
            }            
            Console.WriteLine("Transaction succeed..");
            System.Threading.Thread.Sleep(1500);
        }
        public override string ToString()
        {
            return Name + ". " + Age + " Old" + "\nAdress: " + adress + "\nID: " + id + "\nPassword: " + password;
        }
    }
}
