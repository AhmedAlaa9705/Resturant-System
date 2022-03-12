using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
 //   [BasicAuthenticationFilter]
    public class SearchController : ApiController
    {
        private readonly Smart1Entities4 db;
        public SearchController()
        {
            db = Singleton.GetInstance();
        }
        [HttpGet]
        [Route("Search_Accounts")]
        public IHttpActionResult Search_Accounts(string searchCode, byte type, byte combin, int parentAccId, int moduleCars, string uid, string lang)
        {
            try
            {
                var acc = db.SEARCH_ACCOUNTS(searchCode, type, combin, parentAccId, moduleCars, uid, lang);
                return Ok(acc);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
         
        }
        [HttpGet]
        [Route("Search_AllowancesSanctions")]
        public IHttpActionResult Search_AllowancesSanctions(string searchCode, string type, string lang)
        {
            try
            {
                var model = db.SEARCH_ALLOWANCES_SANCTIONS(searchCode, type, lang);
                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
      
        }
        [HttpGet]
        [Route("Search_Area")]
        public IHttpActionResult Search_Area(string searchCode, string lang)
        {
            try
            {
                var area = db.SEARCH_AREA(searchCode, lang);
                return Ok(area);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("Search_Bills")]
        public IHttpActionResult Search_Bills(short billSettingId, string lang)
        {
            try
            {
                var bills = db.SEARCH_BILLS(billSettingId, lang);
                return Ok(bills);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("Search_ChargeCompany")]
        public IHttpActionResult Search_ChargeCompany(string searchCode, string lang)
        {
            try
            {
                var charge = db.SEARCH_CHARGE_COMPANY(searchCode, lang);
                return Ok(charge);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("Search_CompanyBranch")]
        public IHttpActionResult Search_CompanyBranch(string searchCode, string lang)
        {
            try
            {
                var charge = db.SEARCH_COMPANY_BRANCH(searchCode, lang);
                return Ok(charge);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("Search_CompanyStore")]
        public IHttpActionResult Search_CompanyStore(string searchCode, bool classs, string uid, string lang)
        {
            try
            {
                var companyStore = db.SEARCH_COMPANY_STORE(searchCode, classs, uid, lang);
                return Ok(companyStore);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

           
        }
        [HttpGet]
        [Route("Search_CostCenter")]
        public IHttpActionResult Search_CostCenter(string searchCode, bool fromSearch, string lang)
        {
            try
            {
                var costCenter = db.SEARCH_COST_CENTER(searchCode, fromSearch, lang);
                return Ok(costCenter);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

          
        }
        [HttpGet]
        [Route("SearchEmployee")]
        public IHttpActionResult SearchEmployee(string searchCode, string lang)
        {
            try
            {
                var employee = db.SEARCH_EMPLOYEE(searchCode, lang);
                return Ok(employee);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

           
        }
        [HttpGet]
        [Route("Search_Item")]
        public IHttpActionResult Search_Item(string searchCode, byte searchType, byte searchCodeOrName, byte searchOnlyByDefaultUnit, byte fromSearchOrNot, bool isItOrderedByItemCodeOrNot, string lang)
        {
            try
            {
                var item = db.SEARCH_ITEM(searchCode, searchType, searchCodeOrName, searchOnlyByDefaultUnit, fromSearchOrNot, isItOrderedByItemCodeOrNot, lang);
                return Ok(item);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

          
        }
        [HttpGet]
        [Route("Search_ItemByBarCode")]
        public IHttpActionResult Search_ItemByBarCode(string searchBarCode, string lang)
        {
            try
            {
                var itemByBarCode = db.SEARCH_ITEM_BYBARCODE(searchBarCode, lang);
                return Ok(itemByBarCode);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

           
        }
        [HttpGet]
        [Route("Search_ItemClass")]
        public IHttpActionResult Search_ItemClass(string searchCode, byte searchType, byte searchCodeOrName, byte searchOnlyByDefaultUnit, byte fromSearchOrNot, bool isItOrderedByItemCodeOrNot, string lang)
        {
            try
            {
                var itemclass = db.SEARCH_ITEM_CLASS(searchCode,
                    searchType,
                    searchCodeOrName,
                    searchOnlyByDefaultUnit,
                    fromSearchOrNot, 
                    isItOrderedByItemCodeOrNot,
                    lang);
                return Ok(itemclass);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

            
        }
        [HttpGet]
        [Route("Search_ItemCompany")]
        public IHttpActionResult Search_ItemCompany(string searchCode, string lang)
        {
             try
            {
                var itemCompany = db.SEARCH_ITEM_COMPANY(searchCode, lang);
                return Ok(itemCompany);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

            
        }
        [HttpGet]
        [Route("Search_ItemGroup")]
        public IHttpActionResult Search_ItemGroup(string searchCode, byte groupClass, byte classId, string lang)
        {
            try
            {
                var itemgroub = db.SEARCH_ITEM_GROUP(searchCode, groupClass, classId, lang);
                return Ok(itemgroub);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
          
        }
        [HttpGet]
        [Route("Search_Item1")]
        public IHttpActionResult Search_Item1(string searchCode, byte searchType, byte searchCodeOrName, byte searchOnlyByDefaultUnit, byte fromSearchOrNot, bool isItOrderedByItemCodeOrNot, int groupId, string lang)
        {
            try
            {
                var item1 = db.SEARCH_ITEM1(searchCode,
              searchType, searchCodeOrName,
              searchOnlyByDefaultUnit,
              fromSearchOrNot,
              isItOrderedByItemCodeOrNot,
              groupId, lang);
                return Ok(item1);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

          
        }
        [HttpGet]
        [Route("Search_ItemsPlaces")]
        public IHttpActionResult Search_ItemsPlaces(string searchCode, string lang)
        {
            try
            {
                var itemplaces = db.SEARCH_ITEMS_PLACES(searchCode, lang);
                return Ok(itemplaces);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

          
        }
        [HttpGet]
        [Route("Search_ServiceGroup")]
        public IHttpActionResult Search_ServiceGroup(string searchCode)
        {
            try
            {
                var serviceGroup = db.SEARCH_SERVICE_GROUP(searchCode);
                return Ok(serviceGroup);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

           
        }
        [HttpGet]
        [Route("Search_TemsMark")]
        public IHttpActionResult Search_TemsMark(string searchCode, string lang)
        {

            try
            {
                var temsMark = db.SEARCH_TEMS_MARK(searchCode, lang);
                return Ok(temsMark);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
           
        }
        [HttpGet]
        [Route("Search_Unit")]
        public IHttpActionResult Search_Unit(string searchCode, int itemId, byte searchType, string lang)
        {
            try
            {
                var temsMark = db.SEARCH_UNIT(searchCode, itemId, searchType, lang);
                return Ok(temsMark);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

           
        }

    }
}
