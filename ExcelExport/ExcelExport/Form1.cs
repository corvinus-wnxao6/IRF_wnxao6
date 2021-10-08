using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel= Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        
        List<Flat> lakasok; //= new List<Flat>();

        RealEstateEntities context = new RealEstateEntities();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;

            //Microsoft.Office.Interop.Excel.Application így kéne lehivatkozni hogy ne akadjon össze

            
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            lakasok = context.Flats.ToList(); //itt alakítom listává, másolatot csinál az adatokból
        }
    }
}
