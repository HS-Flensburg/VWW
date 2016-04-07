using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V3_WCF.Contracts
{
    [ServiceContract]
    public interface IUserCheck
    {
        [OperationContract]
        [ServiceKnownType(typeof(User))]
        bool IsAdult(User usr);
    }
}
