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
    
    public partial class UserLogFile
    {
        public int ID { get; set; }
        public string UID { get; set; }
        public string FormName { get; set; }
        public string OpName { get; set; }
        public Nullable<System.DateTime> OpDate { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateOnly { get; set; }
        public Nullable<long> ALL_ID { get; set; }
    }
}
