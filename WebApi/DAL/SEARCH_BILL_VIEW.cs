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
    
    public partial class SEARCH_BILL_VIEW
    {
        public string BILL_NUMBER { get; set; }
        public System.DateTime BILL_DATE { get; set; }
        public long BILL_ID { get; set; }
        public string ACC_AR_NAME { get; set; }
        public string ACC_EN_NAME { get; set; }
        public short BILL_SETTING_ID { get; set; }
        public Nullable<int> SHIFT_NUMBER { get; set; }
        public string WORK_ORDER_NUMBER { get; set; }
        public bool DISABLE { get; set; }
    }
}
