using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VWW_V5_RemotingDemo.Contracts;

namespace VWW_V5_RemotingDemo.Server
{
    class MyService : IMyService
    {
        public string GetHallo(string name)
        {
            return "Hallo " + name;
        }

        public User GetUser()
        {
            return new User()
            {
                Age = 22,
                Name = "User"
            };
        }
    }
}
