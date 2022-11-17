using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected int id;
        protected string password;
        public bool IsAdmin { get; set; }
        public virtual void PrintInfo() { }
        public override string ToString()
        {
            return "ID: " + id + ". " + Name + ". " + Age + " Old";
        }
    }
}
