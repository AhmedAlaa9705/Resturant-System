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
    
    public partial class TCAR
    {
        public int CAR_ID { get; set; }
        public string CAR_CODE { get; set; }
        public Nullable<int> ACC_ID { get; set; }
        public string CAR_AR_NAME { get; set; }
        public string CAR_EN_NAME { get; set; }
        public Nullable<int> CAR_COLOUR_ID { get; set; }
        public Nullable<int> CAR_MODEL_ID { get; set; }
        public Nullable<int> CAR_MARKA_ID { get; set; }
        public Nullable<int> CAR_TYPE_ID { get; set; }
        public Nullable<int> CAR_CLASS_ID { get; set; }
        public string CAR_SHASIH_NUMBER { get; set; }
        public string CAR_ENGINE_NUMBER { get; set; }
        public int CAR_ENGINE_TYPE { get; set; }
        public int CAR_BRANCH_ID { get; set; }
        public System.DateTime CAR_DATE { get; set; }
        public string CAR_NOTES { get; set; }
        public Nullable<int> INSERT_USER { get; set; }
        public Nullable<System.DateTime> INSERT_DATE { get; set; }
        public Nullable<int> MODIFY_USER { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
    }
}
