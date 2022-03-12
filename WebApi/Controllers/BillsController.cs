using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    public class BillsController : ApiController
    {
        private Smart1Entities4 db;
        public BillsController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddBill")]
        public IHttpActionResult AddBill(
            [FromUri]
         string CUST_ACC_CODE ,
            string ITEM_ACC_CODE,
            string CURRENCY_NAME,
            string CUST_BRN_NAME,
            string SALES_CODE,
            string COST_CENTER_CODE,
            string COM_STORE_CODE,
            string TO_COM_STORE_CODE,
            string COM_BRN_CODE,
            string SELL_TYPE_NAME,
            bool MINUS_OPTION,
            bool EXPIRED_OPTION,
            double BILL_INVENTORY_VALUE,
            string PAY_ACC_CODE,
            bool AFFECT_PRICES,
            double TAXES,
            string PostEntry,
            string NUMBER_ENTRY,
            string BRANCHE_NAME,
            string XML_DATA,
            string XML_SECOND_GRID,
            string XML_ENTRY_DETAILS,
            string XML_SERIAL ,
            string XML_SERVICE,
            double S_BILL_TOTAL,
            double S_BILL_DISC,
            double S_BILL_EXTRA,
            bool NORMAL,
            string lang,
            [FromBody] BILL_MASTER billMaster,
          [FromBody]ENTRY_MASTER entryMaster)
        { 
            try
            {

                db.ADD_BILL_MASTER(
                    Convert.ToInt32( billMaster.BILL_SETTING_ID),
                    billMaster.BILL_DATE,
                    billMaster.BILL_NUMBER,
                    CUST_ACC_CODE,
                    ITEM_ACC_CODE,
                    CURRENCY_NAME,
                    billMaster.CURRENCY_RATE,
                    billMaster.BILL_REMARKS,
                    billMaster.BILL_TOTAL,
                    CUST_BRN_NAME,
                    billMaster.BILL_PAY_WAY,
                    billMaster.BILL_TOTAL_DISC,
                    billMaster.BILL_TOTAL_EXTRA,
                    SALES_CODE,
                    COST_CENTER_CODE,
                    COM_STORE_CODE,
                    TO_COM_STORE_CODE,
                    COM_BRN_CODE,
                    billMaster.BILL_IS_POST,
                    SELL_TYPE_NAME, billMaster.ENTRY_ID,
                    billMaster.SHIFT_NUMBER,
                    billMaster.BILL_WIEGHT,
                    Convert.ToBoolean( billMaster.BILL_TYPE),
                    MINUS_OPTION,
                    EXPIRED_OPTION,
                    billMaster.BILL_TYPE,
                    billMaster.BILL_PAIDED,
                    billMaster.kest_value,
                    billMaster.WORK_ORDER_NUMBER,
                    billMaster.COUNTER_VALUE,
                    billMaster.THE_RETURN_PERCENTAGE,
                    billMaster.THE_LAST_DATE_FOR_RETURN,
                    billMaster.BILL_ANOTHER_DISC,
                    BILL_INVENTORY_VALUE,
                    billMaster.IS_IT_RESERVATION,
                    billMaster.BILLCURRENTPAIDEDVALUE,
                    billMaster.BILLCURRENTREMAINVALUE,
                    PAY_ACC_CODE,
                    AFFECT_PRICES,
                    billMaster.BILL_COST,
                    billMaster.BILL_PROFIT,
                    billMaster.BILL_TOTAL_DISC_NOTPAID,
                    TAXES,
                    billMaster.BILL_TOTAL_OTHER_DISC,
                    billMaster.THE_LAST_DATE_FOR_RESEVED,
                    billMaster.RESERVATION_OR_NOT,
                    billMaster.EXTRA_VALUE_ADD,
                    billMaster.EXTRA_VALUE_RATE,
                    NUMBER_ENTRY,
                    BRANCHE_NAME,
                    billMaster.MASTER_BILL_ID,
                    billMaster.Disable,
                    billMaster.ADD14,
                    billMaster.DIS05,
                    billMaster.DIS2,
                    billMaster.DIS65,
                    billMaster.DIS20FROMADD14,
                    billMaster.DIS7,
                    billMaster.CUST_PHONE,
                    PostEntry,
                    entryMaster.ENTRY_SETTING_ID,
                   Convert.ToString( entryMaster.ENTRY_DATE),
                    entryMaster.ENTRY_CREDIT,
                    entryMaster.ENTRY_DEBIT,
                  Convert.ToInt32(  entryMaster.ENTRY_ID),
                    entryMaster.COLLECT_ENTRY_CODE,
                    entryMaster.IS_POSTED,
                    entryMaster.CHECK_NUMBER,
                    Convert.ToString( entryMaster.CHECK_DATE),
                    entryMaster.ENTRY_REMARKS,
                    XML_DATA,
                    XML_SECOND_GRID,
                    XML_ENTRY_DETAILS,
                    XML_SERIAL,
                    S_BILL_TOTAL,
                    S_BILL_DISC,
                    S_BILL_EXTRA,
                    XML_SERVICE,
                    NORMAL,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateBills")]
        public IHttpActionResult UpdateBills(BILL_MASTER billMaster,
            ENTRY_MASTER entryMaster,
            string CUST_ACC_CODE,
            string ITEM_ACC_CODE,
            string CURRENCY_NAME,
            string CUST_BRN_NAME,
            string SALES_CODE,
            string COST_CENTER_CODE,
            string COM_STORE_CODE,
            string TO_COM_STORE_CODE,
            string COM_BRN_CODE,
            string SELL_TYPE_NAME,
            bool MINUS_OPTION,
            bool EXPIRED_OPTION,
            double BILL_INVENTORY_VALUE,
            string PAY_ACC_CODE,
            bool AFFECT_PRICES,
            double TAXES,
            string PostEntry,
            string NUMBER_ENTRY,
            string BRANCHE_NAME,
            string XML_DATA,
            string XML_SECOND_GRID,
            string XML_ENTRY_DETAILS,
            string XML_SERIAL,
            string XML_SERVICE,
            string XML_DATA_Delete,
            string XML_DELETE_SERIAL,
            double S_BILL_TOTAL,
            double S_BILL_DISC,
            double S_BILL_EXTRA,
            bool NORMAL,
            string lang)
        {
            try
            {

                db.MODIFY_BILL_MASTER(billMaster.BILL_ID,
                    Convert.ToInt32(billMaster.BILL_SETTING_ID),
                    billMaster.BILL_DATE,
                    billMaster.BILL_NUMBER,
                    CUST_ACC_CODE,
                    ITEM_ACC_CODE,
                    CURRENCY_NAME,
                    billMaster.CURRENCY_RATE,
                    billMaster.BILL_REMARKS,
                    billMaster.BILL_TOTAL,
                    CUST_BRN_NAME,
                    billMaster.BILL_PAY_WAY,
                    billMaster.BILL_TOTAL_DISC,
                    billMaster.BILL_TOTAL_EXTRA,
                    SALES_CODE,
                    COST_CENTER_CODE,
                    COM_STORE_CODE,
                    TO_COM_STORE_CODE,
                    COM_BRN_CODE,
                    billMaster.BILL_IS_POST,
                    SELL_TYPE_NAME,
                    billMaster.ENTRY_ID,
                    billMaster.BILL_WIEGHT,
                    MINUS_OPTION,
                    EXPIRED_OPTION,
                    billMaster.BILL_TYPE,
                    billMaster.BILL_PAIDED,
                    billMaster.kest_value,
                    billMaster.WORK_ORDER_NUMBER,
                    billMaster.COUNTER_VALUE,
                    billMaster.THE_RETURN_PERCENTAGE,
                    billMaster.THE_LAST_DATE_FOR_RETURN,
                    billMaster.BILL_ANOTHER_DISC,
                    billMaster.IS_IT_RESERVATION,
                    billMaster.BILLCURRENTPAIDEDVALUE,
                    billMaster.BILLCURRENTREMAINVALUE,
                    PAY_ACC_CODE,
                    AFFECT_PRICES,
                    billMaster.BILL_COST,
                    billMaster.BILL_PROFIT,
                    billMaster.BILL_TOTAL_DISC_NOTPAID,
                    billMaster.BILL_TOTAL_OTHER_DISC,
                    billMaster.THE_LAST_DATE_FOR_RESEVED,
                    billMaster.RESERVATION_OR_NOT,
                    billMaster.EXTRA_VALUE_ADD,
                    billMaster.EXTRA_VALUE_RATE,
                    NUMBER_ENTRY,
                    BRANCHE_NAME,
                    billMaster.MASTER_BILL_ID,
                    billMaster.ADD14,
                    billMaster.DIS05,
                    billMaster.DIS2,
                    billMaster.DIS65,
                    billMaster.DIS20FROMADD14,
                    billMaster.DIS7,
                    billMaster.CUST_PHONE,
                    PostEntry,
                    entryMaster.ENTRY_SETTING_ID,
                   entryMaster.ENTRY_DATE,
                    entryMaster.ENTRY_CREDIT,
                    entryMaster.ENTRY_DEBIT,
                  Convert.ToInt32(entryMaster.ENTRY_ID),
                    entryMaster.COLLECT_ENTRY_CODE,
                    entryMaster.IS_POSTED,
                    entryMaster.CHECK_NUMBER,
                    entryMaster.CHECK_DATE,
                    entryMaster.ENTRY_REMARKS,
                    entryMaster.EMP_ID,
                    billMaster.SHIFT_NUMBER,
                    XML_DATA,
                    XML_SECOND_GRID,
                    XML_DATA_Delete,
                    XML_ENTRY_DETAILS,
                    XML_SERIAL,
                   XML_DELETE_SERIAL,
                  Convert.ToInt32( billMaster.BILL_ID),
                    S_BILL_TOTAL,
                    S_BILL_DISC,
                    S_BILL_EXTRA,
                    XML_SERVICE,        
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteBill")]
        public IHttpActionResult DeleteBill(long billId, int sBillId, string xmlSerial, string lang)
        {
            try
            {
                db.DELETE_BILLS(billId, xmlSerial, sBillId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("PostBill")]
        public IHttpActionResult PostBill(long billId, int shiftNumber, string lang)
        {
            try
            {
                db.POST_BILL(billId,shiftNumber ,lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("PostBillEntry")]
        public IHttpActionResult PostBillEntry(ENTRY_MASTER entryMaster, string XML_ENTRY_DETAILS, string currencyName, string lang)
        {
            try
            {
                db.POST_ENTRY(entryMaster.BILL_ID,
                    entryMaster.ENTRY_SETTING_ID,
                    Convert.ToString( entryMaster.ENTRY_DATE),
                    entryMaster.ENTRY_CREDIT,
                    entryMaster.ENTRY_DEBIT,
                    entryMaster.ACC_ID,
                    entryMaster.COLLECT_ENTRY_CODE,
                    entryMaster.IS_POSTED,
                    entryMaster.CHECK_NUMBER,
                    Convert.ToString( entryMaster.CHECK_DATE),
                    entryMaster.ENTRY_REMARKS,
                    currencyName,
                    entryMaster.CURRENCY_RATE,
                    XML_ENTRY_DETAILS,
                    entryMaster.for_kest,
                    Convert.ToInt32( entryMaster.SHIFT_NUMBER),
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBill")]
        public IHttpActionResult GetBill(short billSettingsId, string lang)
        {
            try
            {
                var model = db.SELECT_ALL_BILL_MASTER(billSettingsId, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillView")]
        public IHttpActionResult GetBillView(int billSettingsId, string lang)
        {
            try
            {
                var model= db.BILL_MASTER_VIEW.Where(a => a.BILL_SETTING_ID == billSettingsId).OrderBy(c => c.BILL_DATE).ToList();
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillByBillNumber")]
        public IHttpActionResult GetBillByBillNumber(short billSettingsId, long billNumber, string lang)
        {
            try
            {
                var model = db.SELECT_BILL_MASTER_BY_NUMBER(billSettingsId, billNumber, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillFirstGrid")]
        public IHttpActionResult GetBillFirstGrid(long billId)
        {
            try
            {
                var model = db.BILL_DETAILS_VIEW.Distinct().Where(a => a.QTY > 0 && a.BILL_ID == billId).OrderBy(c => c.GRID_ROW_NUMBER).ToList();
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillServicesDetails")]
        public IHttpActionResult GetBillServicesDetails(string billNumber)
        {
            try
            {
                var model = db.SERVICE_BILL_DETAILS_VIEW.Where(a => a.S_BILL_NUMBER == billNumber).ToList();
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillServices")]
        public IHttpActionResult GetBillServices(string billNumber)
        {
            try
            {
                var model = db.SERVICE_BILL_MASTER.Where(a => a.S_BILL_NUMBER == billNumber).ToList();
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBarcodeTransrate")]
        public IHttpActionResult GetBarcodeTransrate(int itemId, int unitId)
        {
            try
            {
                var model = db.ITEMS_UNITS.Where(a => a.ITEM_ID == itemId).Select(x => new { x.UNIT_BARCODE,x.UNIT_TRANS_RATE}).ToList(); ;
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillSecondGrid")]
        public IHttpActionResult GetBillSecondGrid(long billId)
        {
            try
            {
                var model = db.SELECT_ALL_DISC_ACCOUNTS(billId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        //public IHttpActionResult GetBillUnPaided(long billId)
        //{
        //    try
        //    {
        //        var model = db.UNPAIDED             
        //            return Ok(model);
        //    }
        //    catch (EntityCommandExecutionException ex)
        //    {

        //        return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

        //    }
        // }
        [HttpGet]
        [Route("GetBillDetailsByNumber")]
        public IHttpActionResult GetBillDetailsByNumber(short billId, long billNumber, string lang)
        {
            try
            {
                var model = db.SELECT_BILL_DETAILS_BY_NUMBER(billId,billNumber);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillFirstByNumber")]
        public IHttpActionResult GetBillFirstByNumber(short billId, long billNumber, char lang)
        {
            try
            {
                var model = db.SELECT_BILL_DETAILS_BY_NUMBER(billId, billNumber);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillSecondByNumber")]
        public IHttpActionResult GetBillSecondByNumber(short billId, long billNumber, string lang)
        {
            try
            {
                var model = db.SELECT_DISC_ACCOUNTS_BY_NUMBER(billId, billNumber);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetBillSetting")]
        public IHttpActionResult GetBillSetting(string billName, string lang)
        {
            try
            {
                var model = db.GET_BILL_SETTING(billName, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetGridSetting")]
        public IHttpActionResult GetGridSetting(string billName, string lang)
        {
            try
            {
                var model = db.GET_BILL_GRID_SETTING(billName, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("SearchByBarCode")]
        public IHttpActionResult SearchByBarCode(string barCode, string lang)
        {
            try
            {
                var model = db.SEARCH_ITEM_BYBARCODE(barCode, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateGrid")]
        public IHttpActionResult UpdateGrid(BILL_GRID_COLUMNS billGridColumns, short fromBillOrSettings, string lang)
        {
            try
            {
                 db.MODIFY_BILL_GRID_COLUMNS(billGridColumns.BILL_SETTING_ID,
                    billGridColumns.ITEM_INDEX,
                    billGridColumns.ITEM_WIDTH,
                    billGridColumns.QTY_INDEX,
                    billGridColumns.QTY_WIDTH,
                    billGridColumns.UNIT_COST_INDEX,
                    billGridColumns.UNIT_COST_WIDTH,
                    billGridColumns.TOTAL_INDEX,
                    billGridColumns.TOTAL_WIDTH,
                    billGridColumns.GIFTS_INDEX,
                    billGridColumns.GIFTS_WIDTH,
                    billGridColumns.DISC_RATE_INDEX,
                    billGridColumns.DISC_RATE_WIDTH,
                    billGridColumns.DISC_VALUE_INDEX,
                    billGridColumns.DISC_VALUE_WIDTH,
                    billGridColumns.EXTRA_RATE_INDEX,
                    billGridColumns.EXTRA_RATE_WIDTH,
                    billGridColumns.EXTRA_VALUE_INDEX,
                    billGridColumns.EXTRA_VALUE_WIDTH,
                    billGridColumns.PRODUCTION_DATE_INDEX,
                    billGridColumns.PRODUCTION_DATE_WIDTH,
                    billGridColumns.EXPIRED_DATE_INDEX,
                    billGridColumns.EXPIRED_DATE_WIDTH,
                    billGridColumns.BILL_REMARKS_INDEX,
                    billGridColumns.BILL_REMARKS_WIDTH,
                    billGridColumns.UNIT_INDEX,
                    billGridColumns.UNIT_WIDTH,
                    billGridColumns.ITEM_REMAIN_QTY_INDEX,
                    billGridColumns.ITEM_REMAIN_QTY_WIDTH,
                    billGridColumns.CTOTALCURR_INDEX,
                    billGridColumns.CTOTALCURR_WIDTH,
                    billGridColumns.CEXTERNALLEXPENSES_INDEX,
                    billGridColumns.CEXTERNALLEXPENSES_WIDTH,
                    billGridColumns.CTOTALWITHEXPENSES_INDEX,
                    billGridColumns.CTOTALWITHEXPENSES_WIDTH,
                    billGridColumns.CINVENTORYVALUE_INDEX,
                    billGridColumns.CINVENTORYVALUE_WIDTH,
                    billGridColumns.WHOLE_INDEX,
                    billGridColumns.WHOLE_WIDTH,
                    billGridColumns.HALF_WHOLE_INDEX,
                    billGridColumns.HALF_WHOLE_WIDTH,
                    billGridColumns.RETAIL_INDEX,
                    billGridColumns.RETAIL_WIDTH,
                    billGridColumns.END_USERS_INDEX,
                    billGridColumns.END_USERS_WIDTH,
                    billGridColumns.EMPLOYEE_INDEX,
                    billGridColumns.EMPLOYEE_WIDTH,
                    billGridColumns.EXPORT_INDEX,
                    billGridColumns.EXPORT_WIDTH,
                    billGridColumns.LAST_BUY_INDEX,
                    billGridColumns.LAST_BUY_WIDTH,
                    fromBillOrSettings,
                    lang
                    );
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }



    }


}

