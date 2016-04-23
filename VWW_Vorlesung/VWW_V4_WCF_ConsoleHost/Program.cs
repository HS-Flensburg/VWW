using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using VWW_V4_WCF2;

namespace VWW_VL_WCF_ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost h = new ServiceHost(typeof(MyService)))
            {
                h.Open();
                Console.WriteLine("hit ebter to exit");
                Console.ReadLine();
            }
        }
    }
}
