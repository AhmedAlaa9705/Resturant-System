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
    
    public partial class VSERVICEITEMQTY
    {
        public int SERVICE_ID { get; set; }
        public int ITEM_ID { get; set; }
        public Nullable<double> ITEM_QTY { get; set; }
        public Nullable<short> UNIT_ID { get; set; }
        public Nullable<long> ITEM_UNIT_ID { get; set; }
        public double UNIT_TRANS_RATE { get; set; }
        public string UNIT_CODE { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public string UNIT_EN_NAME { get; set; }
        public Nullable<double> SERVICEQTY { get; set; }
    }
}