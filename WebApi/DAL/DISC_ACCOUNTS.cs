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
    
    public partial class DISC_ACCOUNTS
    {
        public long BILL_ID { get; set; }
        public byte GRID_ROW_NUMBER { get; set; }
        public int ACC_ID { get; set; }
        public Nullable<int> OPPOSITE_ACC_ID { get; set; }
        public Nullable<double> DISC { get; set; }
        public Nullable<double> EXTRA { get; set; }
        public string DISK_ACCOUNTS_REMARKS { get; set; }
    }
}
