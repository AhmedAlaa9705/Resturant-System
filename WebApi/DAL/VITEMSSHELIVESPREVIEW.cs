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
    
    public partial class VITEMSSHELIVESPREVIEW
    {
        public int ITEM_ID { get; set; }
        public int UNIT_ID { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_AR_NAME { get; set; }
        public string EXPORT_PRICE { get; set; }
        public string UNIT_BARCODE { get; set; }
        public string UNIT_AR_NAME { get; set; }
        public string SELLEDISCOUNT { get; set; }
        public double UNIT_TRANS_RATE { get; set; }
        public string WHOLE_PRICE { get; set; }
        public Nullable<bool> QuantityDiscount { get; set; }
        public Nullable<short> QTY_FOR_DIS { get; set; }
        public Nullable<byte> DIS_BY_QTY { get; set; }
        public Nullable<short> QTY_FOR_DIS2 { get; set; }
        public Nullable<byte> DIS_BY_QTY2 { get; set; }
    }
}
