using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class BankAccount
    {
        private int numberOfTransactions = 0;
        public string BankAccountName { get; set; }
        public int BankAccountNumber { get; set; }
        public double Balance { get; set; }
        private string saveAllTransActions = "";
        private const double Interest = 1.30;
        private double Deposit;
        public BankAccount(string BankAccountName, int BankAccountnumber, double Balance)
        {
            this.BankAccountName = BankAccountName;
            this.BankAccountNumber = BankAccountnumber;
            this.Balance = Balance;
        }
        public BankAccount(string BankAccountName, int BankAccountnumber, double Deposit, double Interest)
        {
            this.BankAccountName = BankAccountName;
            this.BankAccountNumber = BankAccountnumber;
            this.Deposit = Deposit;
        }
        private void saveTransaction(double transaction)
        {
            string incomingTransaction = "Transaction: " + numberOfTransactions + ". Account: " + BankAccountName + ". " + ". Account Number: " + BankAccountNumber + ". " + DateTime.Now + ": + " + transaction + "\n";
            saveAllTransActions += incomingTransaction;
        }
        public string displayAllTransactionsFromBankAccount()
        {
            return saveAllTransActions;
        }
        public void GetMoney(double incomingMoney)
        {
            numberOfTransactions++;
            saveTransaction(incomingMoney);
            Balance += incomingMoney;
        }

        public void Withdraw(double withdraw)
        {
            Balance -= withdraw;
        }

        public override string ToString()
        {
            return "Account: " + BankAccountName + "\n Account Number: " + BankAccountNumber + "\nBalance: " + Balance;
        }
    }
}
