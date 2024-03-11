using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMCore.Challanges
{
    public partial class UltraGridDemo : Form
    {
        List<Person> people;
        private object bands;

        public UltraGridDemo()
        {
            InitializeComponent();

            people = new List<Person>();
            for (int i = 0; i < 200; i++)
            {
                Person p = new Person() { ID = 1, Name = "Diego", LastName = "Mendoza", Age = 21, DateOfBirth = new DateTime(1989, 9, 8) };
                people.Add(p);
            }

            //ultraGrid2.DataSource = people;
        }

        //private void ultraGrid2_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        //{
        //    //ultraGrid2.DisplayLayout.Bands[0].AddNew();
        //    //ultraGrid2.DisplayLayout.Bands[1].AddNew();




        //    ultraGrid2.DisplayLayout.Bands[0].Columns[0].Header.Appearance.TextHAlign = HAlign.Center;
        //    ultraGrid2.DisplayLayout.Bands[0].Columns[1].Header.Appearance.TextHAlign = HAlign.Center;
        //    ultraGrid2.DisplayLayout.Bands[0].Columns[2].Header.Appearance.TextHAlign = HAlign.Center;
        //    ultraGrid2.DisplayLayout.Bands[0].Columns[3].Header.Appearance.TextHAlign = HAlign.Center;
        //    ultraGrid2.DisplayLayout.Bands[0].Columns[4].Header.Appearance.TextHAlign = HAlign.Center;
        //}
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
