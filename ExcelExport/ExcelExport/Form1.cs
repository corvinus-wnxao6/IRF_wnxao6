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
        private int _million = (int)Math.Pow(10, 6);

        List<Flat> lakasok; //= new List<Flat>();

        RealEstateEntities context = new RealEstateEntities();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        string[] headers;
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

                CreateTable();
                FormatTable();
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
            headers = new string[]
            {
                    "Kód",
                    "Eladó",
                    "Oldal",
                    "Kerület",
                    "Lift",
                    "Szobák száma",
                    "Alapterület (m2)",
                    "Ár (mFt)",
                    "Négyzetméter ár (Ft/m2)"
            };

            for (int i = 0; i < headers.Length; i++)
            { 
                xlSheet.Cells[1,i+ 1] = headers[i]; 
            }

            //Excel magától el tudja dönteni a cella tartalmának típusát
            object[,] values = new object[lakasok.Count,headers.Length];

            int counter = 0;
            foreach (var lakas in lakasok)
            {
                values[counter, 0] = lakas.Code;
                values[counter, 1] = lakas.Vendor;
                values[counter, 2] = lakas.Side;
                values[counter, 3] = lakas.District;
                if (lakas.Elevator==true)
                {
                    values[counter, 4] = "Van";
                }
                else
                {
                    values[counter, 4] = "Nincs";
                }

                /*if (lakas.Elevator)
                    values[counter, 4] = "Van";
                else
                    values[counter, 4] = "Nincs"; */

                values[counter, 5] = lakas.NumberOfRooms;
                values[counter, 6] = lakas.FloorArea;
                values[counter, 7] = lakas.Price;
                values[counter, 8] = string.Format("={0}/{1}*{2}",
                    "H" + (counter + 2).ToString(),
                    "G" + (counter + 2).ToString(),
                    _million.ToString()); //H2/G2*10000000 
                counter++;
            }

            var range = xlSheet.get_Range(
                                GetCell(2,1),
                                GetCell(1+values.GetLength(0),values.GetLength(1))
                                );
            range.Value2 = values;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void FormatTable()
        {
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit(); //!
            headerRange.RowHeight = 40; //!
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            int lastRowID = xlSheet.UsedRange.Rows.Count;
            Excel.Range completeTableRange = xlSheet.get_Range(GetCell(1, 1), GetCell(lastRowID, headers.Length));
            completeTableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);


        }
    }
}
