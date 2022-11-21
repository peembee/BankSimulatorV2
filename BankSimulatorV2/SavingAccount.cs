using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class SavingAccount
    {
        public string BankAccountName { get; set; }
        public int BankAccountNumber { get; set; }
        public double Deposit { get; set; }
        private const double interest = 1.30;
        public SavingAccount(string BankAccountName, int BankAccountNumber, double deposit)
        {
            this.BankAccountName = BankAccountName;
            this.BankAccountNumber = BankAccountNumber;
            this.Deposit = deposit;
        }
    }
}
