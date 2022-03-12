using System;
using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
   // [BasicAuthenticationFilter]
    public class ReportsController : ApiController
    {
        private readonly Smart1Entities4 db;
        public ReportsController()
        {
            db = Singleton.GetInstance();
        }
        [HttpGet]
        [Route("RPT_AccountMotion")]
        public IHttpActionResult RPT_AccountMotion(string accounts, string options, DateTime startDate, DateTime endDate, string resources)
        {
            try
            {
                var model = db.RPT_ACCOUNT_MOTION(accounts, options, startDate, endDate, resources);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_AccountMotionComplete")]
        public IHttpActionResult RPT_AccountMotionComplete(string accounts, string options, DateTime startDate, DateTime endDate, string resources)
        {
            try
            {
                var model = db.RPT_ACCOUNT_MOTION_COMPLETE(accounts, options, startDate, endDate, resources);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_AccountMotionSpecial")]
        public IHttpActionResult RPT_AccountMotionSpecial(int accountId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_ACCOUNT_MOTION_SPECIAL(accountId, startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("RPT_BillDailyReport")]
        public IHttpActionResult RPT_BillDailyReport(DateTime startDate, DateTime endDate, byte ShiftNumber, string lang)
        {
            try
            {
                var model = db.RPT_BILL_DAILY_REPORT(startDate, endDate, ShiftNumber, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_BillDailyReportByBillId")]
        public IHttpActionResult RPT_BillDailyReportByBillId(long BillId)
        {
            try
            {
                var model = db.RPT_BILL_SUMMARY_PRINT(BillId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpGet]
        [Route("RPT_CashFromCheks")]
        public IHttpActionResult RPT_CashFromCheks(string options, DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_CASH_FROM_CHEKS(options, startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpGet]
        [Route("RPT_CompanyBranchDetails")]
        public IHttpActionResult RPT_CompanyBranchDetails(int comBrnId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_COMPANY_BRANCHES_DETAILS(comBrnId, startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpGet]
        [Route("RPT_CopyrightAuthor")]
        public IHttpActionResult RPT_CopyrightAuthor(int accId, byte calcMethod, DateTime startDate, DateTime finishDate, int accIdMaster)
        {
            try
            {
                var model = db.RPT_COPYRIGHT_AUTHOR(accId, calcMethod, startDate, finishDate, accIdMaster);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_CustomerMotionCategories")]
        public IHttpActionResult RPT_CustomerMotionCategories(int itemId, string reportOptions, DateTime startDate, DateTime finishDate, int accIdMaster)
        {
            try
            {
                var model = db.RPT_CUSTOMER_MOTION_CATEGORIES(itemId, reportOptions, startDate, finishDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_CustomerSales")]
        public IHttpActionResult RPT_CustomerSales(DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_CUSTOMER_SALES(startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_EmpAllSalary")]
        public IHttpActionResult RPT_EmpAllSalary(byte daysWork, DateTime startDate, DateTime finishDate, short deptId)
        {
            try
            {
                var model = db.RPT_EMP_ALL_SALARY(daysWork, startDate, finishDate, deptId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_EmpSalary")]
        public IHttpActionResult RPT_EmpSalary(int accountId, DateTime startDate, DateTime finishDate)
        {
            try
            {
                var model = db.RPT_EMP_SALARY(accountId, startDate, finishDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_EmployeesDaily")]
        public IHttpActionResult RPT_EmployeesDaily(int inOut, DateTime date)
        {
            try
            {
                var model = db.RPT_EMPLOYEES_DAILY(inOut, date);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_EmployeeInOut")]
        public IHttpActionResult RPT_EmployeeInOut(int accountId, DateTime startDate, DateTime finishDate)
        {
            try
            {
                var model = db.RPT_EMPLOYEES_IN_OUT(accountId, startDate, finishDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpGet]
        [Route("RPT_EntryCollection")]
        public IHttpActionResult RPT_EntryCollection(string accounts, string options, DateTime startDate, DateTime endDate, string resources)
        {
            try
            {
                var model = db.RPT_ENTRY_COLLECTION(accounts, options, startDate, endDate, resources);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_EntryCollectionCheks")]
        public IHttpActionResult RPT_EntryCollectionCheks(byte options, DateTime startDate, DateTime endDate, string acc, string accOptions, bool beforeDate, bool allData)
        {
            try
            {
                var model = db.RPT_ENTRY_COLLECTION_CHEKS(options,
                    startDate,
                    endDate, 
                    acc, 
                    accOptions,
                    beforeDate, 
                    allData);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("RPT_EntryTrans")]
        public IHttpActionResult RPT_EntryTrans(byte entrySettingId)
        {
            try
            {
                var model = db.RPT_ENTRY_TRANS(entrySettingId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
         
        }
        [HttpGet]
        [Route("RPT_IncomeData")]
        public IHttpActionResult RPT_IncomeData(DateTime startDate, DateTime endDate, short costCenterId)
        {
            try
            {
                var model = db.RPT_IncomeData(startDate, endDate, costCenterId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_InvoicesReveneu")]
        public IHttpActionResult RPT_InvoicesReveneu(DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_INVOICES_REVENEU(startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_InvoicesReveneuReturn")]
        public IHttpActionResult RPT_InvoicesReveneuReturn()
        {
            try
            {
                var model = db.RPT_INVOICES_REVENEU_RETURN();
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_ItemPrices")]
        public IHttpActionResult RPT_ItemPrices(string nullOptions, string billOptions, int companyId, bool groups)
        {
            try
            {
                var model = db.RPT_ITEM_PRICES(nullOptions, billOptions, companyId, groups);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_ItemQty")]
        public IHttpActionResult RPT_ItemQty(string options, string select, string type)
        {
            try
            {
                var model = db.RPT_ITEM_QTY(options, select, type);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_ItemsInGroupWithSales")]
        public IHttpActionResult RPT_ItemsInGroupWithSales(int groupId, int accId, int storeId, bool showItemsQtyOnly)
        {
            try
            {
                var model = db.RPT_ITEMS_INGROUP_WITH_SALES(groupId, accId, storeId, showItemsQtyOnly);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("RPT_ItemsInventory")]
        public IHttpActionResult RPT_ItemsInventory(string options, string select, string toSelect, DateTime StartDate, DateTime endDate, bool storesDetails, bool expiredView, string sort, int groupId)
        {
            try
            {
                var model = db.RPT_ITEMS_INVENTORY(options, 
                    select,
                    toSelect,
                    StartDate,
                    endDate, 
                    storesDetails,
                    expiredView,
                    sort,
                    groupId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
         
        }
        [HttpGet]
        [Route("RPT_ItemsInventoryByCompany")]
        public IHttpActionResult RPT_ItemsInventoryByCompany(string options, string select, string toSelect, DateTime StartDate, DateTime endDate, bool storesDetails, bool expiredView, string sort, int groupId)
        {
            try
            {
                var model = db.RPT_ITEMS_INVENTORY_BY_COMPANY(options,
                    select,
                    toSelect, 
                    StartDate, 
                    endDate,
                    storesDetails,
                    expiredView,
                    sort,
                    groupId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpGet]
        [Route("RPT_ItemsInventoryStores")]
        public IHttpActionResult RPT_ItemsInventoryStores(int groupId, short comStoreId, int options, byte quick, byte groupsView, bool allStores, string sort, string stores, bool bigUnitShow)
        {
            try
            {
                var model = db.RPT_ITEMS_INVENTORY_Stores(groupId,
                    comStoreId, 
                    options, 
                    quick,
                    groupsView,
                    allStores, 
                    sort, 
                    stores,
                    bigUnitShow);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_ItemsInventoryStoresByAuthors")]
        public IHttpActionResult RPT_ItemsInventoryStoresByAuthors(string stores, int accId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_ITEMS_INVENTORY_Stores_BY_AUTHORS(stores, accId, startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
         
        }
        [HttpGet]
        [Route("RPT_ItemsInventoryStoresByCompany")]
        public IHttpActionResult RPT_ItemsInventoryStoresByCompany(short comStoreId, short account, DateTime startSales, DateTime endSales, int groupId)
        {
            try
            {
                var model = db.RPT_ITEMS_INVENTORY_Stores_BY_COMPANY(comStoreId,
                    account,
                    startSales,
                    endSales,
                    groupId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_NotMovingCustomers")]
        public IHttpActionResult RPT_NotMovingCustomers(DateTime startDate, DateTime endDate, string options, int number, string resources, string accounts, byte type, byte previousBalance)
        {
            try
            {
                var model = db.RPT_NOT_MOVING_CUSTOMERS(startDate,
                    endDate, 
                    options,
                    number, 
                    resources,
                    accounts,
                    type, 
                    previousBalance);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("RPT_PolicyPrices")]
        public IHttpActionResult RPT_PolicyPrices(int groupId)
        {
            try
            {
                var model = db.RPT_POLICY_PRICES(groupId);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpGet]
        [Route("RPT_RevisionAverage")]
        public IHttpActionResult RPT_RevisionAverage(DateTime endDate)
        {
            try
            {
                var model = db.RPT_REVISION_AVERAGE(endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_SupplierMotionCategory")]
        public IHttpActionResult RPT_SupplierMotionCategory(string reportOptions, int supplyId, int storeId, int customerId, DateTime startDate, DateTime finishDate, int type)
        {
            try
            {
                var model = db.RPT_SUPPLIER_MOTION_CATEGORIES(reportOptions, 
                    supplyId, 
                    storeId, 
                    customerId,
                    startDate,
                    finishDate,
                    type);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
         
        }
        [HttpGet]
        [Route("RPT_TotalItemMotion")]
        public IHttpActionResult RPT_TotalItemMotion(string options, string resources, string select, DateTime startDate, DateTime endDate)
        {
            try
            {
                var model = db.RPT_TOTAL_ITEM_MOTION(options, resources, select, startDate, endDate);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
       
        }
        [HttpGet]
        [Route("RPT_UpdateDisc")]
        public IHttpActionResult RPT_UpdateDisc(string xmlData, byte discType, string lang)
        {
            try
            {
                var model = db.RPT_UPDATE_DISC(xmlData, discType, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("RPT_UpdateItemsGroup")]
        public IHttpActionResult RPT_UpdateItemsGroup(string xmlData, string lang)
        {
            try
            {
                var model = db.RPT_UPDATE_ITEMS_GROUP(xmlData, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
    }
}
