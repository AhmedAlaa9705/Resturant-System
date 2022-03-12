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
    
    public partial class SELECT_ALL_BILL_SETTINGS_Result
    {
        public short BILL_SETTING_ID { get; set; }
        public string BILL_AR_NAME { get; set; }
        public string BILL_EN_NAME { get; set; }
        public string BILL_ABRV_AR { get; set; }
        public string BILL_ABRV_EN { get; set; }
        public byte BILL_TYPE_ID { get; set; }
        public Nullable<int> ACC_ITEM_ID { get; set; }
        public Nullable<int> ACC_DISC_ID { get; set; }
        public Nullable<int> ACC_EXTRA_ID { get; set; }
        public Nullable<int> ACC_PAY_ID { get; set; }
        public Nullable<int> ACC_COST_ID { get; set; }
        public Nullable<int> ACC_STORE_ID { get; set; }
        public Nullable<int> ACC_GIFT_ID { get; set; }
        public Nullable<short> COST_CENTER_ID { get; set; }
        public Nullable<short> COM_STORE_ID { get; set; }
        public Nullable<short> TO_COM_STORE_ID { get; set; }
        public string GENERATE_ENTRY_STATE { get; set; }
        public bool IS_AUTO_POSTING { get; set; }
        public bool CONTINEOUS_INVENTORY { get; set; }
        public bool PRICE_COST_EFFECT { get; set; }
        public bool LAST_PAY_PRICE { get; set; }
        public string STORE_EFFECT_STATE { get; set; }
        public bool ABRV_BILL { get; set; }
        public bool SHOW_COST_CENTER { get; set; }
        public bool SHOW_EMPLOYEE { get; set; }
        public Nullable<short> CURRENCY_ID { get; set; }
        public Nullable<double> CURRENCY_RATE { get; set; }
        public Nullable<int> DEFAULT_COLOR { get; set; }
        public Nullable<int> ALTERNATE_COLOR { get; set; }
        public Nullable<bool> OUT_MINUS { get; set; }
        public Nullable<bool> BILL_SHORTCUT { get; set; }
        public Nullable<bool> FIRST_EXPIRE { get; set; }
        public Nullable<bool> MIN_QTY { get; set; }
        public Nullable<bool> SERIAL_NUMBER { get; set; }
        public Nullable<byte> BILL_SELL_TYPE_ID { get; set; }
        public Nullable<byte> SEARCH_ONLY_BY_DEAULT_UNIT { get; set; }
        public Nullable<bool> PRINTHALFPAGE { get; set; }
        public Nullable<bool> PRINTLANDSCIP { get; set; }
        public string BILL_SHOW_NAME { get; set; }
        public int BILL_PAY_TYPE { get; set; }
        public bool DISABLE_BILL_PAY_TYPE { get; set; }
        public bool SHOW_BILL_PAY_TYPE { get; set; }
        public bool AUTOMATIC_DISCOUNT { get; set; }
        public bool PRINTHALFPAGEBYLONG { get; set; }
        public bool MODULE_CARS { get; set; }
        public bool PRINT_BILL_AUTOMATIC { get; set; }
        public bool SHOW_THE_RETURN_PERCENTAGE { get; set; }
        public bool SHOW_THE_LAST_DATE_FOR_RETURN { get; set; }
        public bool SHOW_THE_LAST_BALANCE_ON_THE_BILL { get; set; }
        public Nullable<bool> PRINT_BILL_AS_RESET_OR_AS_BILL { get; set; }
        public Nullable<double> NUMBEROFCOPIES { get; set; }
        public Nullable<bool> IS_IT_CASHER_BILL { get; set; }
        public Nullable<bool> REPEATETHE_ITEM_AT_THE_BILL { get; set; }
        public string FIRSTBILLMESSAGE { get; set; }
        public string SECONDBILLMESSAGE { get; set; }
        public string HEADERBILLMESSAGE { get; set; }
        public Nullable<bool> SHOW_THE_COMPANY_DATA_ON_BILL { get; set; }
        public Nullable<bool> SHOW_THE_CURRENT_QTY_ON_BILL { get; set; }
        public Nullable<bool> IS_IT_SERVICE_BILL { get; set; }
        public Nullable<bool> GENERATE_COST_ENTRY { get; set; }
        public Nullable<bool> SHOW_THE_ITEM_CODE_ON_BILL { get; set; }
        public Nullable<bool> ADD_BILL_ENTRY_WITH_THE_MAIN_CURRENCY_RATE { get; set; }
        public Nullable<bool> SHOW_THE_CURRENCY { get; set; }
        public Nullable<bool> THESECONDCELLISTHEITEMCELLNOTTHEQUANTITY { get; set; }
        public Nullable<bool> IS_IT_SALES_POINT { get; set; }
        public Nullable<bool> PRINT_BILL_AS_RESET_EXTRA { get; set; }
        public Nullable<bool> SHOW_THE_DATE_FOR_RESEVED { get; set; }
        public Nullable<bool> SHOW_THE_COMPANY_LOGO_ON_BILL { get; set; }
        public Nullable<bool> PASSWORD_EXC { get; set; }
        public Nullable<int> ACC_VISA_ID { get; set; }
        public Nullable<int> ACC_VISA_COST_ID { get; set; }
        public Nullable<double> VISA_COST { get; set; }
        public short BILL_SETTING_ID1 { get; set; }
        public byte ITEM_INDEX { get; set; }
        public short ITEM_WIDTH { get; set; }
        public byte QTY_INDEX { get; set; }
        public short QTY_WIDTH { get; set; }
        public byte UNIT_COST_INDEX { get; set; }
        public short UNIT_COST_WIDTH { get; set; }
        public byte TOTAL_INDEX { get; set; }
        public short TOTAL_WIDTH { get; set; }
        public byte GIFTS_INDEX { get; set; }
        public short GIFTS_WIDTH { get; set; }
        public byte DISC_RATE_INDEX { get; set; }
        public short DISC_RATE_WIDTH { get; set; }
        public byte DISC_VALUE_INDEX { get; set; }
        public short DISC_VALUE_WIDTH { get; set; }
        public byte EXTRA_RATE_INDEX { get; set; }
        public short EXTRA_RATE_WIDTH { get; set; }
        public byte EXTRA_VALUE_INDEX { get; set; }
        public short EXTRA_VALUE_WIDTH { get; set; }
        public byte PRODUCTION_DATE_INDEX { get; set; }
        public short PRODUCTION_DATE_WIDTH { get; set; }
        public byte EXPIRED_DATE_INDEX { get; set; }
        public short EXPIRED_DATE_WIDTH { get; set; }
        public byte BILL_REMARKS_INDEX { get; set; }
        public short BILL_REMARKS_WIDTH { get; set; }
        public byte UNIT_INDEX { get; set; }
        public short UNIT_WIDTH { get; set; }
        public Nullable<byte> ITEM_REMAIN_QTY_INDEX { get; set; }
        public Nullable<short> ITEM_REMAIN_QTY_WIDTH { get; set; }
        public Nullable<byte> CTOTALCURR_INDEX { get; set; }
        public Nullable<short> CTOTALCURR_WIDTH { get; set; }
        public Nullable<byte> CEXTERNALLEXPENSES_INDEX { get; set; }
        public Nullable<short> CEXTERNALLEXPENSES_WIDTH { get; set; }
        public Nullable<byte> CTOTALWITHEXPENSES_INDEX { get; set; }
        public Nullable<short> CTOTALWITHEXPENSES_WIDTH { get; set; }
        public Nullable<byte> CINVENTORYVALUE_INDEX { get; set; }
        public Nullable<short> CINVENTORYVALUE_WIDTH { get; set; }
        public Nullable<byte> WHOLE_INDEX { get; set; }
        public Nullable<short> WHOLE_WIDTH { get; set; }
        public Nullable<byte> HALF_WHOLE_INDEX { get; set; }
        public Nullable<short> HALF_WHOLE_WIDTH { get; set; }
        public Nullable<byte> RETAIL_INDEX { get; set; }
        public Nullable<short> RETAIL_WIDTH { get; set; }
        public Nullable<byte> END_USERS_INDEX { get; set; }
        public Nullable<short> END_USERS_WIDTH { get; set; }
        public Nullable<byte> EMPLOYEE_INDEX { get; set; }
        public Nullable<short> EMPLOYEE_WIDTH { get; set; }
        public Nullable<byte> EXPORT_INDEX { get; set; }
        public Nullable<short> EXPORT_WIDTH { get; set; }
        public Nullable<byte> LAST_BUY_INDEX { get; set; }
        public Nullable<short> LAST_BUY_WIDTH { get; set; }
        public Nullable<byte> DISC_RATE_NOTPAID_INDEX { get; set; }
        public Nullable<short> DISC_RATE_NOTPAID_WITH { get; set; }
    }
}
