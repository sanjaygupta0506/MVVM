using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Factory_Method
{
    public abstract class CreditCardFactory
    {
        //public static CreditCard GetCreditCard(string CardType)
        //{
        //    CreditCard cardDetails = null;
        //    if(CardType == "MoneyBack")
        //    {
        //        cardDetails = new MoneyBack();
        //    }
        //    if(CardType == "Titnium")
        //    {
        //        cardDetails = new Titanium();
        //    }
        //    if(CardType == "Platinum")
        //    {
        //        cardDetails = new Platinum();
        //    }
        //    return cardDetails;
        //}

        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
