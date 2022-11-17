using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class Admin : User
    {
        Bank bank;

        public Admin(string name, int age, int idNumber, string password)
        {
            bank = new Bank();
            this.Name = name;
            this.Age = age;
            id = idNumber;
            IsAdmin = true;
            this.password = password;
            AdminMainMenu();
        }



        public void GetMeny(int userId)
        {
            if (id == userId)
            {
                AdminMainMenu();
            }
            else
            {
                bank.Menu(userId);
            }
        }
        private void AdminMainMenu()
        {
            string userChoice = "";
            Console.Clear();
            while (userChoice != "0")
            {
                Console.Clear();
                Console.WriteLine("Menu for Admin");
                Console.WriteLine("----------------------");
                Console.WriteLine("#1: Unlock Customer");
                Console.WriteLine("#2: Add Customer");
                Console.WriteLine("#3: Display all customers");
                Console.WriteLine("#0: Sign Out");
                Console.WriteLine("----------------------");
                Console.Write("Enter option: ");
                userChoice = Console.ReadLine();
                userChoice = userChoice.Trim();
                switch (userChoice)
                {
                    case "1":
                        unLockCustomer();
                        break;
                    case "2":
                        addCustomer();
                        break;
                    case "3":
                        PrintInfo();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            Console.WriteLine("signing out, please wait");
            System.Threading.Thread.Sleep(1500);
        }
        private void unLockCustomer()
        {

        }

        private void addCustomer()
        {
            string name = "";
            string adress = "";
            int age = 0;
            int id = 0;
            string password = "";
            double wallet = 0;
            Console.Clear();
            Console.Write("Customer Name: ");
            name = Console.ReadLine();
            Console.Clear();
            Console.Write("Customer Adress: ");
            adress = Console.ReadLine();
            Console.Clear();
            Console.Write("Customer Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Customer ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Password: ");
            password = Console.ReadLine();
            Console.Clear();
            Console.Write("Customer Wallet: ");
            wallet = Convert.ToDouble(Console.ReadLine());
            bank.addNewCustomer(name, adress, age, id, password, wallet);
            Console.Clear();
            Console.WriteLine("New customer has been added");
            System.Threading.Thread.Sleep(1000);
        }

        public override void PrintInfo()
        {
            Console.Clear();
            bank.printMemberList();
            Console.WriteLine("\nkey for menu..");
            Console.ReadKey();
        }
        public bool VerifyUser(int getId)
        {
            bool verified = false;
            if (id == getId)
            {
                verified = true;
            }
            else if(bank.VerifyUserSignIn(getId, verified) == true)
            {                
                    verified = true;                
            }
            return verified;
        }
        public bool VerifyUser(string getPassword)
        {
            bool verified = false;
            if (password == getPassword)
            {
                verified = true;
            }
            else if(bank.VerifyUserSignIn(getPassword, verified) == true)
            {           
                    verified = true;              
            }
            return verified;
        }
    }
}
