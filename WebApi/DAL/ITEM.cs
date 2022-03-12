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
    
    public partial class ITEM
    {
        public int ITEM_ID { get; set; }
        public string ITEM_CODE { get; set; }
        public int GROUP_ID { get; set; }
        public string ITEM_AR_NAME { get; set; }
        public string ITEM_EN_NAME { get; set; }
        public string ITEM_REMARKS { get; set; }
        public bool PRODUCTION_DATE { get; set; }
        public bool EXPIRED_DATE { get; set; }
        public bool SERIAL_IN_INPUT { get; set; }
        public bool SERIAL_IN_OUTPUT { get; set; }
        public byte[] ITEM_PIC { get; set; }
        public Nullable<double> MIN_QTY { get; set; }
        public Nullable<byte> ITEM_TYPE { get; set; }
        public Nullable<int> ITEM_COLOR { get; set; }
        public string ITEM_MODEL { get; set; }
        public string ITEM_BRAND { get; set; }
        public Nullable<int> COMPANY_ID { get; set; }
        public double SELLEDISCOUNT { get; set; }
        public double BURCHASEDISCOUNT { get; set; }
        public Nullable<bool> DOESTHEQUANTITYISAPARTOFBARCODE { get; set; }
        public Nullable<double> QUANTITYLENGTHATTHEBARCODE { get; set; }
        public Nullable<double> QUANTITYSTARTATTHEBARCODE { get; set; }
        public Nullable<int> COST_CALCULATION_TYPE { get; set; }
        public Nullable<double> SELLEDISCOUNTCASH { get; set; }
        public Nullable<double> BURCHASEDISCOUNTCASH { get; set; }
        public Nullable<double> AVG_NOW { get; set; }
        public Nullable<double> AVG_OLD { get; set; }
        public Nullable<double> ITEM_QTY_OLD { get; set; }
        public bool GeneratePrices { get; set; }
        public string PART_NO { get; set; }
        public Nullable<bool> QuantityDiscount { get; set; }
        public Nullable<short> QTY_FOR_DIS { get; set; }
        public Nullable<byte> DIS_BY_QTY { get; set; }
        public Nullable<short> QTY_FOR_DIS2 { get; set; }
        public Nullable<byte> DIS_BY_QTY2 { get; set; }
        public Nullable<byte> PLACE_ID { get; set; }
        public bool COPY_RIGHT { get; set; }
        public bool ITEM_STOP { get; set; }
        public bool NON_TAX { get; set; }
        public Nullable<short> MARK_ID { get; set; }
    }
}