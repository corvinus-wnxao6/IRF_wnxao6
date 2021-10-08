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

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;

            //Microsoft.Office.Interop.Excel.Application így kéne lehivatkozni hogy ne akadjon össze

            CreateExcel();
            CreateTable();
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            lakasok = context.Flats.ToList(); //itt alakítom listává, másolatot csinál az adatokból
        }

        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;


                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string hiba = string.Format("Error: {0}\nLine: {1}",ex.Message,ex.Source);
                MessageBox.Show(hiba, "Error");
                
                xlWB.Close(false,Type.Missing,Type.Missing);
                xlApp.Quit();
                xlWB = null; //FONTOS A SORREND!!
                xlApp = null; //vs még a memóriában tartaná enélkül
            }
            finally
            {
                //akkor is lefut ha catch-el megakadna a progi

            }
        }

        private void CreateTable()
        {

        }
    }
}
