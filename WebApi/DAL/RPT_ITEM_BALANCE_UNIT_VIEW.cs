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
    
    public partial class RPT_ITEM_BALANCE_UNIT_VIEW
    {
        public int ITEM_ID { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_AR_NAME { get; set; }
        public Nullable<double> WHOLE_PRICE { get; set; }
        public Nullable<double> UNIT_TRANS_RATE { get; set; }
        public double QTY { get; set; }
        public Nullable<System.DateTime> BILL_DATE { get; set; }
        public Nullable<double> GIFT { get; set; }
        public Nullable<byte> BILL_TYPE { get; set; }
        public int GROUP_ID { get; set; }
        public Nullable<System.DateTime> EXPIRED_DATE { get; set; }
        public Nullable<short> COM_STORE_ID { get; set; }
        public Nullable<short> TO_COM_STORE_ID { get; set; }
        public Nullable<bool> BILL_IS_POST { get; set; }
        public Nullable<short> COST_CENTER_ID { get; set; }
        public Nullable<double> MIN_QTY { get; set; }
        public Nullable<int> COMPANY_ID { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public string DEFAULT_UNIT_AR_NAME { get; set; }
        public Nullable<double> HALF_WHOLE_PRICE { get; set; }
        public Nullable<double> EMP_PRICE { get; set; }
        public Nullable<double> EXPORT_PRICE { get; set; }
        public Nullable<double> RETAIL_PRICE { get; set; }
        public Nullable<double> CONSUMER_PRICE { get; set; }
        public Nullable<double> LAST_BUY_PRICE { get; set; }
        public Nullable<short> UNIT_ID { get; set; }
    }
}