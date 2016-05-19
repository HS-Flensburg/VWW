using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_EF_CodeFirst
{
    public class Monitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Preis { get; set; }

        public Hersteller Hersteller { get; set; }
    }
}
