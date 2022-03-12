using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.DAL;
using WebApi.Singletons;

namespace WebApi.Security
{
    public class UserSecurity
    {
        public static bool Login(string uid,string password,string formName)
        {
            using (Smart1Entities4 db = new Smart1Entities4 ())
            {
                
                return db.UIDs.Any(a => a.UID1.Equals(uid,

                    StringComparison.OrdinalIgnoreCase) && a.UPWD == password);
            }
        }
    }
}