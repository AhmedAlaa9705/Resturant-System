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
    
    public partial class GET_ENTRY_DETAILS_Result
    {
        public long ENTRY_ID { get; set; }
        public short ENTRY_ROW_NUMBER { get; set; }
        public int ACC_ID { get; set; }
        public double ENTRY_CREDIT { get; set; }
        public double ENTRY_DEBIT { get; set; }
        public string ENTRY_DETAILS_REMARKS { get; set; }
        public Nullable<short> COST_CENTER_ID { get; set; }
        public string ACC_CODE { get; set; }
        public string ACC_NAME { get; set; }
        public string COST_CENTER_CODE { get; set; }
        public string COST_CENTER_NAME { get; set; }
        public string ACC_CUSTOMER_CODE { get; set; }
        public Nullable<bool> ACC_MUST_COST_CENTER { get; set; }
    }
}