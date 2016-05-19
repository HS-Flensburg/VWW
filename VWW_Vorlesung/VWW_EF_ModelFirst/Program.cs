using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbc = new Model1Container())
            {
                dbc.HerstellerSet.Add(new Hersteller()
                {
                    Name = "Dell"
                });
                dbc.SaveChanges();
                foreach (var item in dbc.HerstellerSet)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
