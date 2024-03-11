using MainApplication;
using MainApplication.CommonUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMCore.Challanges.Winforms
{
    public partial class CustomDataGrid : Form  
    {
        public CustomDataGrid()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetEmpList();

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeMgr.ThemeBackgroundColourWindow;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ThemeMgr.CaranuThemeForgroundDrawingColour;


            //VerticalScrollBar.Visible = true;
           
            //VerticalScrollBar.VisibleChanged += new EventHandler(VerScroll);
           
            //HorizontalScrollBar.Visible = true;
            
           // HorizontalScrollBar.VisibleChanged += new EventHandler(HorScroll);

        }


        protected List<Emp> GetEmpList()
        {
            List<Emp> lEmp = new List<Emp>();
            Emp oemp = new Emp(1234, "Devesh Omar", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1234, "ROLI", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1235, "ROLI", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1236, "ROLI", "Kanpur");
            lEmp.Add(oemp);
            oemp = new Emp(1237, "Manish Omar", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1238, "ROLI1", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1239, "ROLI2", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1230, "ROLI3", "CNB");
            lEmp.Add(oemp);
            oemp = new Emp(1231, "ROLI4", "CNB-UP");
            lEmp.Add(oemp);
            oemp = new Emp(1232, "ROLI5", "GHAZIABAD");
            lEmp.Add(oemp);
            oemp = new Emp(1233, "ROLI6", "UP");
            lEmp.Add(oemp);
            Emp oemp1 = new Emp(1234, "Devesh Omar", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1234, "ROLI", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1235, "ROLI", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1236, "ROLI", "Kanpur");
            lEmp.Add(oemp);
            oemp = new Emp(1237, "Manish Omar", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1238, "ROLI1", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1239, "ROLI2", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1230, "ROLI3", "CNB");
            lEmp.Add(oemp);
            oemp = new Emp(1231, "ROLI4", "CNB-UP");
            lEmp.Add(oemp);
            oemp = new Emp(1232, "ROLI5", "GHAZIABAD");
            lEmp.Add(oemp);
            oemp = new Emp(1233, "ROLI6", "UP");
            lEmp.Add(oemp);
            Emp oemp2 = new Emp(1234, "Devesh Omar", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1234, "ROLI", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1235, "ROLI", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1236, "ROLI", "Kanpur");
            lEmp.Add(oemp);
            oemp = new Emp(1237, "Manish Omar", "GZB");
            lEmp.Add(oemp);
            oemp = new Emp(1238, "ROLI1", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1239, "ROLI2", "MainPuri");
            lEmp.Add(oemp);
            oemp = new Emp(1230, "ROLI3", "CNB");
            lEmp.Add(oemp);
            oemp = new Emp(1231, "ROLI4", "CNB-UP");
            lEmp.Add(oemp);
            oemp = new Emp(1232, "ROLI5", "GHAZIABAD");
            lEmp.Add(oemp);
            oemp = new Emp(1233, "ROLI6", "UP");
            lEmp.Add(oemp);
            return lEmp;
        }

        private void CustomDataGrid_Load(object sender, EventArgs e)
        {

        }
    }

    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public Emp(int id, string name, string city)
        {
            this.ID = id;
            this.Name = name;
            this.City = city;
        }
    }


}
