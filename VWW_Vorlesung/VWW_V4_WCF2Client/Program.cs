using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VWW_V4_WCF2Client.myWebService;

namespace VWW_V4_WCF2Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            myWebService.MyServiceClient client = new myWebService.MyServiceClient();
            User u = client.getUser();
            client.print("Haalo Flensburg");
            Console.WriteLine(u.Age);
            Console.ReadKey();
        }
    }
}
