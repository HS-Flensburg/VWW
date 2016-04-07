using System;
using VWW_V3_WCF.Contracts;

namespace VWW_V3_WCF.Server
{
    internal class MyUserCheck : IUserCheck
    {
        public bool IsAdult(User usr)
        {
            return usr.Age >= 18;
        }
    }
}