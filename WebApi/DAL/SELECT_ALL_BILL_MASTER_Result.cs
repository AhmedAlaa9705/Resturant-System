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
    
    public partial class SELECT_ALL_BILL_MASTER_Result
    {
        public long BILL_ID { get; set; }
        public short BILL_SETTING_ID { get; set; }
        public System.DateTime BILL_DATE { get; set; }
        public string BILL_NUMBER { get; set; }
        public Nullable<int> CUST_ACC_ID { get; set; }
        public Nullable<int> ITEM_ACC_ID { get; set; }
        public Nullable<short> CURRENCY_ID { get; set; }
        public Nullable<double> CURRENCY_RATE { get; set; }
        public string BILL_REMARKS { get; set; }
        public Nullable<double> BILL_TOTAL { get; set; }
        public Nullable<int> CUST_BRN_ID { get; set; }
        public string BILL_PAY_WAY { get; set; }
        public Nullable<double> BILL_TOTAL_DISC { get; set; }
        public Nullable<double> BILL_TOTAL_EXTRA { get; set; }
        public Nullable<short> EMP_ID { get; set; }
        public Nullable<short> COST_CENTER_ID { get; set; }
        public Nullable<short> COM_STORE_ID { get; set; }
        public Nullable<short> TO_COM_STORE_ID { get; set; }
        public Nullable<short> COM_BRN_ID { get; set; }
        public bool BILL_IS_POST { get; set; }
        public Nullable<byte> SELL_TYPE_ID { get; set; }
        public Nullable<long> ENTRY_ID { get; set; }
        public Nullable<int> SHIFT_NUMBER { get; set; }
        public Nullable<double> BILL_WIEGHT { get; set; }
        public Nullable<byte> BILL_TYPE { get; set; }
        public Nullable<double> BILL_PAIDED { get; set; }
        public Nullable<double> kest_value { get; set; }
        public string WORK_ORDER_NUMBER { get; set; }
        public string COUNTER_VALUE { get; set; }
        public Nullable<double> THE_RETURN_PERCENTAGE { get; set; }
        public Nullable<System.DateTime> THE_LAST_DATE_FOR_RETURN { get; set; }
        public Nullable<double> BILL_ANOTHER_DISC { get; set; }
        public Nullable<bool> IS_IT_RESERVATION { get; set; }
        public Nullable<double> BILLCURRENTPAIDEDVALUE { get; set; }
        public Nullable<double> BILLCURRENTREMAINVALUE { get; set; }
        public Nullable<int> PAY_ACC_ID { get; set; }
        public Nullable<double> BILL_COST { get; set; }
        public Nullable<double> BILL_PROFIT { get; set; }
        public Nullable<double> BILL_TOTAL_DISC_NOTPAID { get; set; }
        public Nullable<double> BILL_TOTAL_OTHER_DISC { get; set; }
        public Nullable<System.DateTime> THE_LAST_DATE_FOR_RESEVED { get; set; }
        public Nullable<bool> RESERVATION_OR_NOT { get; set; }
        public Nullable<long> BILL_NUMBER2 { get; set; }
        public Nullable<double> EXTRA_VALUE_ADD { get; set; }
        public Nullable<double> EXTRA_VALUE_RATE { get; set; }
        public Nullable<long> MASTER_BILL_ID { get; set; }
        public bool Disable { get; set; }
        public Nullable<bool> ADD14 { get; set; }
        public Nullable<bool> DIS05 { get; set; }
        public Nullable<bool> DIS2 { get; set; }
        public Nullable<bool> DIS65 { get; set; }
        public Nullable<bool> DIS20FROMADD14 { get; set; }
        public Nullable<bool> DIS7 { get; set; }
        public string CUST_PHONE { get; set; }
    }
}
