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
    
    public partial class BILL_MASTER_TEMP_VIEW
    {
        public long BILL_ID { get; set; }
        public short BILL_SETTING_ID { get; set; }
        public System.DateTime BILL_DATE { get; set; }
        public string BILL_NUMBER { get; set; }
        public Nullable<int> CUST_ACC_ID { get; set; }
        public string BILL_REMARKS { get; set; }
        public string BILL_PAY_WAY { get; set; }
        public Nullable<short> EMP_ID { get; set; }
        public Nullable<short> COM_STORE_ID { get; set; }
        public byte SELL_TYPE_ID { get; set; }
        public int SHIFT_NUMBER { get; set; }
        public bool SAVED { get; set; }
        public string ACC_CUSTOMER_CODE { get; set; }
        public string ACC_AR_NAME { get; set; }
        public string COM_STORE_AR_NAME { get; set; }
        public string COM_STORE_CODE { get; set; }
        public string EMP_CODE { get; set; }
        public string EMP_AR_NAME { get; set; }
    }
}
