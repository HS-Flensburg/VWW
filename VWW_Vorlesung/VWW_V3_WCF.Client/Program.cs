using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VWW_V3_WCF.Contracts;

namespace VWW_V3_WCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress ep = new EndpointAddress("http://localhost:8080/test/user");
            ChannelFactory<IUserCheck> channelFac = new ChannelFactory<IUserCheck>(
                new BasicHttpBinding(), ep);
            IUserCheck proxy = null;
            try
            {
                Console.WriteLine("hit enter to run");
                Console.ReadKey();

                proxy = channelFac.CreateChannel();
                User u = new User()
                {
                    Name = "Tester",
                    Age = 20
                };
                bool b = proxy.IsAdult(u);

                Console.WriteLine(b);
                Console.WriteLine("hit enter to exit");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                if (proxy != null)
                    ((ICommunicationObject)proxy).Abort();
            }

            Console.ReadLine();
        }
    }
}
