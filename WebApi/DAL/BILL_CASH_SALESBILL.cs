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
    
    public partial class BILL_CASH_SALESBILL
    {
        public long BILL_ID { get; set; }
        public System.DateTime BILL_DATE { get; set; }
        public string BILL_NUMBER { get; set; }
        public string BILL_REMARKS { get; set; }
        public Nullable<double> BILL_TOTAL { get; set; }
        public string BILL_PAY_WAY { get; set; }
        public Nullable<double> BILL_TOTAL_DISC { get; set; }
        public Nullable<double> BILL_TOTAL_EXTRA { get; set; }
        public Nullable<double> BILL_TOTAL_DISC_NOTPAID { get; set; }
        public Nullable<double> BILL_TOTAL_OTHER_DISC { get; set; }
        public Nullable<double> EXTRA_VALUE_ADD { get; set; }
        public Nullable<double> EXTRA_VALUE_RATE { get; set; }
        public string BILL_AR_NAME { get; set; }
        public string PAY_TYPE_AR_NAME { get; set; }
        public string COM_STORE_AR_NAME { get; set; }
        public string UID { get; set; }
        public bool BILL_IS_POST { get; set; }
        public Nullable<long> ENTRY_ID { get; set; }
        public string UID_PAY { get; set; }
        public string ACC_AR_NAME { get; set; }
        public Nullable<byte> Bill_Type { get; set; }
    }
}
