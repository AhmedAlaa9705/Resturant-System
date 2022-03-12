using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.DAL;

namespace WebApi.Singletons
{
    public class Singleton
    {
        private static Smart1Entities4 _db=null;
        public static Smart1Entities4 GetInstance()
        {
                if (_db == null)
                {
                    _db = new Smart1Entities4();
                }
                return _db;
        }
    }
}