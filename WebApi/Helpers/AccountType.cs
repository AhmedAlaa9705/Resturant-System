using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.DAL;

namespace WebApi.Helpers
{
    
    public enum AccountType
    {
        
       Normal=1,
       Final=2,
       Collective=3,
       Distributive=4,
       NormalCustomer=5,
       NormalSupplier=6,
       NormalCustandsupp=7,
       NormalBox=8,
       NormalBank=9,
       NormalBoxAndBank=10,

    }
}