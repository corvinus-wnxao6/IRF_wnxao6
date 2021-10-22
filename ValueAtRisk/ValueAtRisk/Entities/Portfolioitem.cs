using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAtRisk.Entities
{
    class Portfolioitem
    {
        public string Index { get; set; }
        public decimal Volume { get; set; } //doubleként nem lehet pénzügyi adatokat tárolni, mert nagy különbség lenne

    }
}
