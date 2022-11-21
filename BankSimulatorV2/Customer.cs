using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            accountName = accountName.Trim();
            if (accountName.Length > 0)
            {
                accountName = char.ToUpper(accountName[0]) + accountName.Substring(1);
            }
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
                saveAccList.Add(new SavingAccount(accountName, accountNumber, deposit));
                System.Threading.Thread.Sleep(1000);
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
            Console.WriteLine("------------------");
            foreach (var bankAccount in bankAccList)
            {
                Console.WriteLine(bankAccount);
                Console.WriteLine("------------------");
            }
            
            Console.WriteLine("\nSaving-Accounts");
            Console.WriteLine("------------------");
            foreach (var saveAccounts in saveAccList)
            {
                Console.WriteLine(saveAccounts);
                Console.WriteLine("------------------");
            }            
            Console.WriteLine("Key for menu..");
            Console.ReadKey();
        }

        public void TransferMoneyBetweenBankAccounts()
        {
            string getAccount;
            string toAccount;
            double withdraw = 0;
            string balance = "";
            Console.Clear();
            if (bankAccList.Count <= 1)
            {
                Console.WriteLine("You need to have atleast two bankaccounts to do transfers");
                Console.WriteLine("Key for menu..");
                Console.ReadKey();
            }
            else
            {
                while (true)
                {
                    bool breakLoop = false;
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------");
                        foreach (var bankaccounts in bankAccList)
                        {
                            Console.WriteLine(bankaccounts.BankAccountName + ": $" + bankaccounts.Balance);
                        }
                        Console.WriteLine("--------------------------");
                        Console.Write("Which Bank-Account would you like withdraw from: ");
                        getAccount = Console.ReadLine();
                        getAccount = getAccount.Trim();
                        getAccount = getAccount.ToLower();

                        if (getAccount.Length > 0)
                        {
                            getAccount = char.ToUpper(getAccount[0]) + getAccount.Substring(1);
                            break;
                        }
                    }
                    foreach (var bankaccounts in bankAccList)
                    {
                        if (getAccount == bankaccounts.BankAccountName)
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Balance $: " + bankaccounts.Balance.ToString());
                                Console.Write("Enter amount to withdraw: ");
                                try
                                {
                                    withdraw = Convert.ToDouble(Console.ReadLine());
                                    if (withdraw <= bankaccounts.Balance)
                                    {
                                        bankaccounts.Withdraw(withdraw);
                                        breakLoop = true;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't withdraw more than you have in " + bankaccounts.BankAccountName + ", Try again");
                                    }
                                }
                                catch (Exception)
                                {
                                    // Do nothing
                                }
                            }
                        }
                    }
                    if (breakLoop == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Did not find any Bankaccount with that name");
                        System.Threading.Thread.Sleep(1500);
                    }
                }
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
                    Console.Write("Which Bank-Account would you like to deposit to: ");
                    toAccount = Console.ReadLine();
                    toAccount = toAccount.Trim();
                    toAccount = toAccount.ToLower();

                    if (toAccount.Length > 0)
                    {
                        toAccount = char.ToUpper(toAccount[0]) + toAccount.Substring(1);
                        if (toAccount == getAccount)
                        {
                            Console.WriteLine("You cant transfer to the same account.");
                            System.Threading.Thread.Sleep(1500);
                        }
                        else
                        {
                            foreach (var bankaccounts in bankAccList)
                            {
                                if (toAccount == bankaccounts.BankAccountName)
                                {

                                    bankaccounts.GetMoney(withdraw);
                                    breakLoop = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (breakLoop == true)
                    {
                        break;
                    }
                    else if (toAccount != getAccount)
                    {
                        Console.WriteLine("Did not find the Account, try again..");
                        System.Threading.Thread.Sleep(1500);
                    }
                }
                Console.WriteLine("Transaction succeed..");
                System.Threading.Thread.Sleep(1500);
            }
        }
        public override string ToString()
        {
            return Name + ". " + Age + " Old" + "\nAdress: " + adress + "\nID: " + id + "\nPassword: " + password;
        }
    }
}
