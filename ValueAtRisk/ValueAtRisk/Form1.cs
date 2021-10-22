using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueAtRisk.Entities;

namespace ValueAtRisk
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<Portfolioitem> Portfolios = new List<Portfolioitem>();

        public Form1()
        {
            InitializeComponent();

            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;

            CreatePortfolio();
            int elemszám = Portfolios.Count();
            decimal részvényekÖsszege = (from x in Portfolios
                                         select x.Volume).Sum();
            MessageBox.Show(string.Format("Részvények száma: {0}", részvényekÖsszege));

            
        }

        private void CreatePortfolio()
        {

            Portfolios.Add(new Portfolioitem() { Index = "OTP", Volume = 10 });
            Portfolios.Add(new Portfolioitem() { Index = "ZWACK", Volume = 10 });
            Portfolios.Add(new Portfolioitem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolios;
        }

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolios)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim()
                               && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }












        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
