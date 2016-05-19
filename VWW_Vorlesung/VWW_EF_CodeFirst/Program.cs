using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbc = new Model2())
            {
                Console.WriteLine(dbc.Hersteller.Find(1).Monitors.First().Name);
                Console.ReadKey();
            }
        }
    }
}
