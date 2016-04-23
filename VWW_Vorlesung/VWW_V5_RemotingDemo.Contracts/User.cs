using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V5_RemotingDemo.Contracts
{
    /*
    ---- Remoting ----
    DTOs must derive from MarshalByRefObject (https://msdn.microsoft.com/de-de/library/system.marshalbyrefobject%28v=vs.110%29.aspx).
    Marshalling/Remoting means that between AppDomains or machines, rather than serialize and transfer the object,
    the object stays at one end and a proxy is created at the other. All method calls to the proxy are intercepted
    and the call is transmitted as RPC causing the method to execute on the other machine (typically serialising
    the arguments and return value).
    */
    public class User : MarshalByRefObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool print(string s)
        {
            //if called on the client-side, this
            //code will be executed server-side
            Console.WriteLine(s);
            return true;
        }
    }
}
