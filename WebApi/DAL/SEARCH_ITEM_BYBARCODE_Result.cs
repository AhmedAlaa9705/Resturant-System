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
    
    public partial class SEARCH_ITEM_BYBARCODE_Result
    {
        public int ITEM_ID { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_AR_NAME { get; set; }
        public int UNIT_ID { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public int UNIT_MASTER_UNIT_ID { get; set; }
        public double UNIT_TRANS_RATE { get; set; }
        public Nullable<double> WHOLE_PRICE { get; set; }
        public Nullable<double> HALF_WHOLE_PRICE { get; set; }
        public Nullable<double> EMP_PRICE { get; set; }
        public Nullable<double> EXPORT_PRICE { get; set; }
        public Nullable<double> RETAIL_PRICE { get; set; }
        public Nullable<double> CONSUMER_PRICE { get; set; }
        public Nullable<double> LAST_BUY_PRICE { get; set; }
        public bool PRODUCTION_DATE { get; set; }
        public bool EXPIRED_DATE { get; set; }
        public bool SERIAL_IN_INPUT { get; set; }
        public bool SERIAL_IN_OUTPUT { get; set; }
    }
}
