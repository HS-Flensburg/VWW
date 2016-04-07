using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V3_WCF.Contracts
{
    public interface IUserCheck
    {
        bool IsAdult(User usr);
    }
}
