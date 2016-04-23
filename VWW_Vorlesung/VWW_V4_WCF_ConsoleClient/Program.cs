using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V4_WCF_ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.MyServiceClient cl = new ServiceReference1.MyServiceClient("NetTcpBinding_IMyService");
            var usr = cl.getUser();
            Console.WriteLine(usr.Name);
            Console.ReadKey();
        }
    }
}
