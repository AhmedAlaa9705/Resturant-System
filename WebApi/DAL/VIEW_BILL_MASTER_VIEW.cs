//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class VIEW_BILL_MASTER_VIEW
    {
        public string ITEM_AR_NAME { get; set; }
        public double QTY { get; set; }
        public Nullable<double> UNIT_PRICE { get; set; }
        public string ITEM_CODE { get; set; }
        public long BILL_ID { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public string QTY_PRINT { get; set; }
        public string UNIT_PRICE_PRINT { get; set; }
        public string TOTAL_BILL { get; set; }
        public Nullable<bool> IS_DEFAULT { get; set; }
    }
}
