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
    
    public partial class SEARCH_ITEMS
    {
        public string ITEM_CODE { get; set; }
        public string ITEM_AR_NAME { get; set; }
        public string ITEM_EN_NAME { get; set; }
        public int GROUP_ID { get; set; }
        public int ITEM_ID { get; set; }
        public Nullable<int> UNIT_ID { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public string UNIT_EN_NAME { get; set; }
        public Nullable<int> UNIT_MASTER_UNIT_ID { get; set; }
        public Nullable<double> UNIT_TRANS_RATE { get; set; }
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
        public string UNIT_BARCODE { get; set; }
        public Nullable<double> MIN_QTY { get; set; }
        public double SELLEDISCOUNT { get; set; }
        public double BURCHASEDISCOUNT { get; set; }
        public Nullable<bool> DOESTHEQUANTITYISAPARTOFBARCODE { get; set; }
        public Nullable<double> QUANTITYLENGTHATTHEBARCODE { get; set; }
        public Nullable<double> QUANTITYSTARTATTHEBARCODE { get; set; }
        public Nullable<double> SELLEDISCOUNTCASH { get; set; }
        public Nullable<double> BURCHASEDISCOUNTCASH { get; set; }
        public Nullable<byte> ITEM_TYPE { get; set; }
        public string PART_NO { get; set; }
        public bool NON_TAX { get; set; }
        public string GROUP_AR_NAME { get; set; }
        public string ACC_AR_NAME { get; set; }
        public bool ITEM_STOP { get; set; }
        public Nullable<bool> IS_DEFAULT { get; set; }
        public Nullable<bool> GROUP_STOP { get; set; }
        public Nullable<int> ITEM_UNIT_ID { get; set; }
        public Nullable<double> AVG_NOW { get; set; }
    }
}
