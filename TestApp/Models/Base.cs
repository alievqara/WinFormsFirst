using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Base
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public int Exchange { get; set; }
        public string baseAsset { get; set; }
        public string auoteAsset { get; set; }
        public double volatility { get; set; }
        public double liquidity { get; set; }
    }
}
