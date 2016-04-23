using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V5_RemotingDemo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            MyService ser = new MyService();
            ChannelServices.RegisterChannel(new TcpChannel(8080));
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MyService), "GetHallo", WellKnownObjectMode.Singleton);
            Console.WriteLine("Ready...");
            Console.ReadKey();
        }
    }
}
