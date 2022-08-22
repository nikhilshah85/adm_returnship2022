using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public class Accounts
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public double pBalance { get; set; }
        public bool pIsActive { get; set; }
        public string pType { get; set; }

        public double Widraw(int amount)
        {
            this.pBalance = this.pBalance - amount;
            return pBalance;
        }
        public double Deposit(int amount)
        {
            this.pBalance = this.pBalance - amount;
            return pBalance;
        }

        public string GreetUser(string uName)
        {
            return "Welcome to Banking";
        }

        public int NewAddMethod(int firstNum, int secondNum)
        {
            return firstNum + secondNum + 5000;
        }




    }
}
