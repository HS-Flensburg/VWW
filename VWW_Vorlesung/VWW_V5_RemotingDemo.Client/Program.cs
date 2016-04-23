using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using VWW_V5_RemotingDemo.Contracts;

namespace VWW_V5_RemotingDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to start");
            Console.ReadKey();
            ChannelServices.RegisterChannel(new TcpChannel());
            IMyService ser = (IMyService)Activator.GetObject(typeof(IMyService), "tcp://localhost:8080/GetHallo");
            Console.WriteLine(ser.GetHallo("Ben"));
            User u = ser.GetUser();
            Console.WriteLine(u.Name);
            u.print("print");
            Console.ReadKey();
        }
    }
}
