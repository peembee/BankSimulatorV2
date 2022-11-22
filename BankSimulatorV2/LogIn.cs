using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class LogIn
    {
        private int passwordGuesses = 3;
        private int id;
        private string password;

        Admin admin;
        public LogIn()
        {
            string getAdminName;
            int getAdminAge;
            int getAdminId;
            string getAdminPassword;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    First Startup");
            Console.Write("   L");
            System.Threading.Thread.Sleep(200);
            Console.Write("O");
            System.Threading.Thread.Sleep(200);
            Console.Write("A");
            System.Threading.Thread.Sleep(200);
            Console.Write("D");
            System.Threading.Thread.Sleep(200);
            Console.Write("I");
            System.Threading.Thread.Sleep(200);
            Console.Write("N");
            System.Threading.Thread.Sleep(200);
            Console.Write("G\n");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("Create Admin\n");
            Console.ResetColor();
            while (true)
            {
                Console.Write("Enter Name: ");
                getAdminName = Console.ReadLine();
                getAdminName = getAdminName.Trim();
                getAdminName = getAdminName.ToLower();
                if (getAdminName.Length > 2 && getAdminName.Length < 10)
                {
                    getAdminName = char.ToUpper(getAdminName[0]) + getAdminName.Substring(1);
                    break;
                }
                else
                {
                    Console.WriteLine("Minimum Characters: 3");
                    Console.WriteLine("Maximum Characters: 9");
                }
            }
            Console.Clear();

            while (true)
            {
                Console.Write("Enter Age: ");
                try
                {
                    getAdminAge = Convert.ToInt32(Console.ReadLine());
                    if (getAdminAge > 17 && getAdminAge < 91)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Accepted age: 18 - 90");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input..\n");
                }
            }
            Console.Clear();

            while (true)
            {
                Console.Write("Choose ID For Admin [4 Numbers]: ");
                try
                {
                    getAdminId = Convert.ToInt32(Console.ReadLine());
                    if (getAdminId.ToString().Length == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Id needs to contain 4 digit numbers.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input..Try Again\n");
                }
            }
            Console.Clear();

            while (true)
            {
                Console.Write("Enter Password: ");
                getAdminPassword = Console.ReadLine();
                getAdminPassword = getAdminPassword.Trim();
                if (getAdminPassword.Length > 2 && getAdminPassword.Length < 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Minimum Characters: 3");
                    Console.WriteLine("Maximum Characters: 9");
                }
            }
            admin = new Admin(getAdminName, getAdminAge, getAdminId, getAdminPassword);
        }
        public void SignInMenu()
        {
            Console.Clear();
            while (true)
            {
                while (true)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Exit Bank application, press 0");
                        Console.WriteLine("---------------------------------------------");
                        Console.Write("\nEnter ID: ");
                        try
                        {
                            id = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("invalid input, try again");
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                    if (id == 0)
                    {
                        Console.WriteLine("Closing application..");
                        System.Threading.Thread.Sleep(1500);
                        break;
                    }
                    if (admin.VerifyUser(id) == true)
                    {
                        break;
                    }
                }
                while (admin.VerifyUser(id) == true)
                {                    
                    Console.WriteLine(admin.ReadPasswordTriesOrDecreasePasswordtries(id, true)); // Only read passwordTries.
                    Console.Write("Enter Password: ");
                    password = Console.ReadLine();
                    if (admin.VerifyUser(password) == true)
                    {
                        admin.GetMeny(id);
                        break;
                    }
                    else
                    {
                        admin.ReadPasswordTriesOrDecreasePasswordtries(id);
                    }
                }
            }
        }
    }
}
