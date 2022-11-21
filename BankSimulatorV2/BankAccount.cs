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
        private int numberOfTransactions = 0;
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

        public BankAccount(string BankAccountName, int BankAccountnumber, double Balance)
        {
            this.bankAccountName = BankAccountName;
            this.BankAccountNumber = BankAccountnumber;
            this.balance = Balance;
        }

        private void saveTransaction(double transaction)
        {
            string incomingTransaction = "Transaction: " + numberOfTransactions + ". Account: " + BankAccountName + ". " + ". Account Number: " + BankAccountNumber + ". " + DateTime.Now + ": + " + transaction + "\n";
            saveAllTransActions += incomingTransaction;
        }
        public string displayAllTransactionsFromBankAccount()
        {
            if (saveAllTransActions == "")
            {
                saveAllTransActions = "You don't have any transactions..";
            }
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
            balance -= withdraw;
        }

        public override string ToString()
        {
            return "Account: " + BankAccountName + "\n Account Number: " + BankAccountNumber + "\nBalance: " + Balance;
        }
    }
}
