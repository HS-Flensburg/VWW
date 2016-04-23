using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V5_RemotingDemo.Contracts
{
    public interface IMyService
    {
        string GetHallo(string name);
        User GetUser();
    }
}
