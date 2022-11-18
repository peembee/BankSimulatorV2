using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorV2
{
    internal class User
    {
        protected bool isAdmin;
        protected int id;
        protected string password;
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value;}
        }
        public virtual void PrintInfo() { }
        public override string ToString()
        {
            return "ID: " + id + ". " + Name + ". " + Age + " Old";
        }
    }
}
