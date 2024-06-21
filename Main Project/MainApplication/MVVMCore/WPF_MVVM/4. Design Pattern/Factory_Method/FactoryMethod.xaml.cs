using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Factory_Method
{
    /// <summary>
    /// Interaction logic for FactoryMethod.xaml
    /// </summary>
    public partial class FactoryMethod : WslDialog
    {
        public FactoryMethod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region Without Factory Method
            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            //string cardType = "";
            //CreditCard cardDetails = null;
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            //if (cardType == "MoneyBack")
            //{
            //    cardDetails = new MoneyBack();
            //}
            //else if (cardType == "Titanium")
            //{
            //    cardDetails = new Titanium();
            //}
            //else if (cardType == "Platinum")
            //{
            //    cardDetails = new Platinum();
            //}
            //if (cardDetails != null)
            //{
            //    textBox1.Text = ("CardType : " + cardDetails.GetCardType());
            //    textBox2.Text = ("CreditLimit : " + cardDetails.GetCreditLimit());
            //    textBox3.Text = ("AnnualCharge :" + cardDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.ReadLine();

            #endregion

            #region With Factory Method

            //CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            //if (cardDetails != null)
            //{
            //    textBox1.Text = ("CardType : " + cardDetails.GetCardType());
            //    textBox2.Text = ("CreditLimit : " + cardDetails.GetCreditLimit());
            //    textBox3.Text = ("AnnualCharge :" + cardDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.ReadLine();

            #endregion

            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                textBox1.Text = ("CardType : " + creditCard.GetCardType());
                textBox2.Text = ("CreditLimit : " + creditCard.GetCreditLimit());
                textBox3.Text = ("AnnualCharge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                textBox4.Text = ("CardType : " + creditCard.GetCardType());
                textBox5.Text = ("CreditLimit : " + creditCard.GetCreditLimit());
                textBox6.Text = ("AnnualCharge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
