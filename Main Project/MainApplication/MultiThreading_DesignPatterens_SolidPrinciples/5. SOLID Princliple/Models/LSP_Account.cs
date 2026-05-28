using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.SOLID_Princliple.Models
{
    //#region Normal
    //public class Account
    //{
    //    public virtual void Withdraw(double amount)
    //    {
    //        // Withdraw money from the account
    //    }
    //}

    //public class SavingsAccount : Account
    //{
    //    public override void Withdraw(double amount)
    //    {
    //        if (amount > 1000)
    //        {
    //            throw new Exception("Withdrawal amount exceeded limit");
    //        }

    //        // Withdraw money from the savings account
    //    }
    //}

    //public class CurrentAccount : Account
    //{
    //    public override void Withdraw(double amount)
    //    {
    //        if (amount > 5000)
    //        {
    //            throw new Exception("Withdrawal amount exceeded limit");
    //        }

    //        // Withdraw money from the current account
    //    }
    //}
    //#endregion

    #region Liskov Substitution Principle (LSP) 
    public interface IAccount
    {
        void Withdraw(double amount);
    }

    public class SavingsAccount : IAccount
    {
        public void Withdraw(double amount)
        {
            if (amount > 1000)
            {
                throw new Exception("Withdrawal amount exceeded limit");
            }

            // Withdraw money from the savings account
        }
    }

    public class CurrentAccount : IAccount
    {
        public void Withdraw(double amount)
        {
            if (amount > 5000)
            {
                throw new Exception("Withdrawal amount exceeded limit");
            }

            // Withdraw money from the current account
        }
    }
    #endregion

}
