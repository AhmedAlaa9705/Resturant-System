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
    
    public partial class RPT_BILL_ITEM_PRICES
    {
        public string UNIT_CODE { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public string UNIT_EN_NAME { get; set; }
        public string UNIT_BARCODE { get; set; }
        public Nullable<double> UNIT_TRANS_RATE { get; set; }
        public string ITEM_AR_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_EN_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_AR_NAME { get; set; }
        public string GROUP_EN_NAME { get; set; }
        public Nullable<double> WHOLE_PRICE { get; set; }
        public Nullable<double> HALF_WHOLE_PRICE { get; set; }
        public Nullable<double> EMP_PRICE { get; set; }
        public Nullable<double> EXPORT_PRICE { get; set; }
        public Nullable<double> CONSUMER_PRICE { get; set; }
        public Nullable<double> RETAIL_PRICE { get; set; }
        public Nullable<int> GROUP_ID { get; set; }
        public Nullable<int> ITEM_ID { get; set; }
        public Nullable<byte> BILL_TYPE { get; set; }
        public Nullable<long> BILL_ID { get; set; }
        public Nullable<short> BILL_SETTING_ID { get; set; }
        public Nullable<short> COM_STORE_ID { get; set; }
        public double QTY { get; set; }
        public Nullable<double> UNIT_PRICE { get; set; }
        public Nullable<System.DateTime> BILL_DATE { get; set; }
        public Nullable<double> LAST_BUY_PRICE { get; set; }
    }
}
