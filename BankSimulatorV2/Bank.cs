using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class Bank
    {
        private int userSignInId;
        string AdminInfo = "";


        List<Customer> customersList = new List<Customer>();

        public void Menu(int userId)
        {
            userSignInId = userId;
            int menuSelect = 0;
            string[] menuOptions = new string[]
            { "Sign Out",
              "Add New Bank-Account",
              "Add Save Account",
              "Add Loan Account",
              "Display Your Saving-Accoounts",
              "Display Your Bankloan",
              "Display All Your Transaction",
              "Display All Your Bank-Accounts and Save-Accounts",
              "Display AdminInfo"
            };

            Console.Clear();
            Console.WriteLine("            Bank Menu");
            Console.WriteLine("         ---------------");

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("--------------");
                Console.WriteLine("Signed in");
                foreach (var cust in customersList)
                {
                    if (cust.IdNumber == userId)
                    {
                        Console.WriteLine(cust.Name);
                        Console.WriteLine("ID: " + cust.IdNumber);
                    }
                }
                Console.WriteLine("--------------");
                if (menuSelect == 0)
                {
                    Console.WriteLine("<< " + menuOptions[0] + " >>");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                }

                else if (menuSelect == 1)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("<< " + menuOptions[1] + " >>");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("<< " + menuOptions[2] + " >>");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                }
                else if (menuSelect == 3)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("<< " + menuOptions[3] + " >>");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                }
                else if (menuSelect == 4)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("<< " + menuOptions[4] + " >>");
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                }
                else if (menuSelect == 5)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine("<< " + menuOptions[5] + " >>");
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                }
                else if (menuSelect == 6)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine("<< " + menuOptions[6] + " >>");
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
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
                    Console.WriteLine("<< " + menuOptions[7] + " >>");
                    Console.WriteLine(menuOptions[8]);
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
                    Console.WriteLine("<< " + menuOptions[8] + " >>");
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
                            Environment.Exit(0);
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
                            Console.WriteLine(AdminInfo);
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


        }

        private void addLoanAccount()
        {


        }

        private void viewSavingAccounts()
        {

        }

        private void viewBankLoan()
        {

        }

        private void viewAllTypeOfTransactions()
        {


        }

        private void viewAllBankAndSavingAccounts()
        {

        }
        private void viewAdminInfo(string getAdminInfo)
        {
            AdminInfo = getAdminInfo;
        }
        public List<Customer> cloneCustomerList()
        {
            return customersList;
        }
    }
}
