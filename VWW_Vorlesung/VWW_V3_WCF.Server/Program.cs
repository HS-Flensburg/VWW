using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VWW_V3_WCF.Contracts;

namespace VWW_V3_WCF.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;
            try
            {
                host = new ServiceHost(typeof(MyUserCheck));
                host.AddServiceEndpoint(typeof(IUserCheck), new BasicHttpBinding(), new Uri("http://localhost:8080/test/user"));
                host.Open();
                Console.WriteLine("hit enter to exit");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (host != null)
                    host.Close();
            }
        }
    }
}
