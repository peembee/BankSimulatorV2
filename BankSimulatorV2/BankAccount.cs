using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class BankAccount
    {
        private double balance;
        private string bankAccountName;
        private int numberOfTransactions;
        private string saveAllTransActions = "";
        public string BankAccountName
        {
            get
            {
                return bankAccountName;
            }
            set
            {
                bankAccountName = value;
            }
        }
        public int BankAccountNumber { get; set; }
        public double Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                balance = value;
            }
        }

        public BankAccount(string bankAccountName, int bankAccountnumber, double balance)
        {            
            this.bankAccountName = bankAccountName;
            this.BankAccountNumber = bankAccountnumber;
            this.balance = balance;            
            saveTransaction(balance);
        }
        private void saveTransaction(double transaction, string withdraw = "no")
        {
            numberOfTransactions++;
            if (withdraw == "no")
            {
                string incomingTransaction = "Transaction: " + numberOfTransactions + ". Account: " + BankAccountName + ". " + ". Account Number: " + BankAccountNumber + ". " + DateTime.Now + ": + " + transaction + "\n";
                saveAllTransActions = saveAllTransActions + incomingTransaction;
            }
            else
            {
                string incomingTransaction = "Transaction: " + numberOfTransactions + ". Account: " + BankAccountName + ". " + ". Account Number: " + BankAccountNumber + ". " + DateTime.Now + ": - " + transaction + "\n";
                saveAllTransActions = saveAllTransActions + incomingTransaction;
            }
        }
        public string displayAllTransactionsFromBankAccount()
        {
                return saveAllTransActions;
        }
        public void GetMoney(double incomingMoney)
        {
            saveTransaction(incomingMoney);
            Balance += incomingMoney;
        }
        public void Withdraw(double withdraw)
        {
            balance -= withdraw;
            saveTransaction(withdraw, "yes");
        }
        public override string ToString()
        {
            return "Account: " + BankAccountName + "\nAccount Number: " + BankAccountNumber + "\nBalance: " + Balance;
        }
    }
}
