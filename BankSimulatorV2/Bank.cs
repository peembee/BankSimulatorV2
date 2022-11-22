using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class Bank
    {
        private int userSignInId;
        private string adminInfo;
        int menuSelect;

        private List<Customer> customersList = new List<Customer>();

        public Bank(string adminInfo)
        {
            this.adminInfo = adminInfo;
        }
        public void Menu(int userId)
        {
            userSignInId = userId;
            string[] menuOptions = new string[]
            { "Sign Out",
              "Add New Bank-Account",
              "Add Save Account",
              "Add Loan Account",
              "Display Your Saving-Accoounts",
              "Display Your Bankloan",
              "Display All Your Transaction",
              "Display All Your Bank-Accounts and Save-Accounts",
              "Display AdminInfo",
              "Transfer Money Between Accounts"
            };

            Console.Clear();
            Console.WriteLine("            Bank Menu");
            Console.WriteLine("         ---------------");
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("--------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Signed in: ");
                Console.ResetColor();
                foreach (var cust in customersList)
                {
                    if (cust.IdNumber == userId)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(cust.Name);
                        Console.WriteLine("\nID: " + cust.IdNumber);
                        Console.WriteLine("Wallet: $" + cust.Wallet);
                        Console.WriteLine("debt: " + cust.BankLoan);
                        Console.ResetColor();
                        break;
                    }
                }
                Console.WriteLine("--------------");
                if (menuSelect == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[0] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }

                else if (menuSelect == 1)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[1] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[2] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 3)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[3] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 4)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[4] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 5)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[5] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 6)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[6] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 7)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[7] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 8)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[8] + " >>");
                    Console.ResetColor();
                    Console.WriteLine(menuOptions[9]);
                }
                else if (menuSelect == 9)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("<< " + menuOptions[9] + " >>");
                    Console.ResetColor();
                }
                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:
                            Console.Clear();                            
                            break;
                        case 1:
                            addBankAccount();
                            break;
                        case 2:
                            addSaveAccount();
                            break;
                        case 3:
                            addLoanAccount();
                            break;
                        case 4:
                            viewSavingAccounts();
                            break;
                        case 5:
                            viewBankLoan();
                            break;
                        case 6:
                            viewAllTypeOfTransactions();
                            break;
                        case 7:
                            viewAllBankAndSavingAccounts();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine(adminInfo);
                            Console.WriteLine("\nKey for menu..");
                            Console.ReadKey();
                            break;
                        case 9:
                            transferMoneyBetweenAccounts();
                            break;
                    }
                    if(menuSelect == 0)
                    {
                        break;
                    }
                }
            }
        }
        public void addNewCustomer(string Name, string adress, int Age, int idNumber, string password, double wallet)
        {
            customersList.Add(new Customer(Name, adress, Age, idNumber, password, wallet));
        }
        private void addBankAccount()
        {
            foreach(var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.AddNewBankAccount();
                    break;
                }
            }
        }
        private void addSaveAccount()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.AddSavingAccount();
                }
            }
        }
        private void addLoanAccount()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.AddLoan();
                }
            }

        }
        private void viewSavingAccounts()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.DisplaySaveAccount();
                }
            }
        }
        private void viewBankLoan()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.DisplayBankLoan();
                }
            }
        }
        private void viewAllTypeOfTransactions()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.AllTransactionOnCustomer();
                }
            }
        }
        private void viewAllBankAndSavingAccounts()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.DisplayAllBankAndSavingAccount();
                }
            }
        }
        private void transferMoneyBetweenAccounts()
        {
            foreach (var customer in customersList)
            {
                if (userSignInId == customer.IdNumber)
                {
                    customer.TransferMoneyBetweenBankAccounts();
                    break;
                }
            }
        }
        public List<Customer> cloneCustomerList()
        {
            return customersList;
        }
        public List<Customer> GetUpdatedCustList(List<Customer> updatedList)
        {
            customersList = updatedList;
            return customersList;
        }
    }
}
