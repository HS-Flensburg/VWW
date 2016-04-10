using System;
using System.Security.Permissions;
using VWW_V3_WCF.Contracts;

namespace VWW_V3_WCF.Server
{
    internal class MyUserCheck : IUserCheck
    {
        //[PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public bool IsAdult(User usr)
        {
            Console.WriteLine("checking user :" + usr.Name);
            return usr.Age >= 18;
        }
    }
}