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
    
    public partial class COMPANY_BRANCHES
    {
        public int COM_BRN_ID { get; set; }
        public string COM_BRN_CODE { get; set; }
        public string COM_BRN_AR_NAME { get; set; }
        public string COM_BRN_EN_NAME { get; set; }
        public string COM_BRN_AR_ABRV { get; set; }
        public string COM_BRN_EN_ABRV { get; set; }
        public short NATION_ID { get; set; }
        public short GOV_ID { get; set; }
        public Nullable<int> TOWN_ID { get; set; }
        public Nullable<long> VILLAGE_ID { get; set; }
        public string COM_BRN_ADDR_REMARKS { get; set; }
        public Nullable<int> COM_MASTER_BRN_ID { get; set; }
        public string COM_BRN_REMARKS { get; set; }
        public Nullable<short> COST_CENTER_ID { get; set; }
        public Nullable<int> ACC_PAY_ID { get; set; }
    }
}