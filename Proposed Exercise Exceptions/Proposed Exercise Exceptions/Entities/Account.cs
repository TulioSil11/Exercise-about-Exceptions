
using Proposed_Exercise_Exceptions.Entities.Exeptions;

namespace Proposed_Exercise_Exceptions.Entities
{
    class Account
    {
        //class atributes---------------------------
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }
        public double withdrawLimit { get; set; }
        //-------------------------------------------

        //builders----------------------------------------------------------------------

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {

            this.number = number;
            this.holder = holder;
            this.balance = balance;
            this.withdrawLimit = withdrawLimit;
        }

        //-------------------------------------------------------------------------------

        //class methods ---------------------------------------------------------------------
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void withDraw(double amount)
        {
            if (balance == 0)
            {
                throw new DomainExeptions(" Not enough balance.");
            } 
            if (amount > withdrawLimit)
            {
                throw new DomainExeptions("The amount exceeds withdraw limit");
            }
            if (amount > balance)
            { 
                throw new DomainExeptions("Not enough balance. ");
            }
            else
            {
                balance -= amount;
            }

            
        }
        //---------------------------------------------------------------------------------------
    }
}
