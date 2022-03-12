using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;
namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class CompanyStoreController : ApiController
    {
        private Smart1Entities4 db;
        public CompanyStoreController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddCompanyStore")]
        public IHttpActionResult AddCompanyStore(COMPANY_STORES companyStore, byte teleTypeId, string lang, string xmlTelephones=null)
        {
            try
            {
                db.ADD_COMPANY_STORES(companyStore.COM_STORE_CODE,
                    companyStore.COM_STORE_AR_NAME,
                    companyStore.COM_STORE_EN_NAME,
                    companyStore.COM_STORE_AR_ABRV,
                    companyStore.COM_STORE_EN_ABRV,
                    companyStore.NATION_ID,
                    companyStore.GOV_ID,
                    companyStore.TOWN_ID,
                    companyStore.VILLAGE_ID,
                    companyStore.COM_STORE_ADDR_REMARKS,
                    companyStore.COM_MASTER_STORE_ID.ToString(),
                    companyStore.COM_STORE_REMARKS,
                    companyStore.COM_BRN_ID.ToString(),
                    companyStore.EMP_ID,
                    companyStore.COM_PRINTER_NAME,
                    teleTypeId,
                    xmlTelephones,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateCompanyStore")]
        public IHttpActionResult UpdateCompanyStore(COMPANY_STORES companyStore, byte teleTypeId, string lang, string xmlTelephones=null)
        {
            try
            {
                db.MODIFY_COMPANY_STORES(companyStore.COM_STORE_ID,
                    companyStore.COM_STORE_CODE,
                    companyStore.COM_STORE_AR_NAME,
                    companyStore.COM_STORE_EN_NAME,
                    companyStore.COM_STORE_AR_ABRV,
                    companyStore.COM_STORE_EN_ABRV,
                    companyStore.NATION_ID,
                    companyStore.GOV_ID,
                    companyStore.TOWN_ID,
                    companyStore.VILLAGE_ID,
                    companyStore.COM_STORE_ADDR_REMARKS,
                    companyStore.COM_MASTER_STORE_ID.ToString(),
                    companyStore.COM_STORE_REMARKS,
                    companyStore.COM_BRN_ID.ToString(),
                    companyStore.EMP_ID,
                    companyStore.COM_PRINTER_NAME,
                    teleTypeId,
                    xmlTelephones,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteCompanyStore")]
        public IHttpActionResult DeleteCompanyStore(short companyStoreId, byte teleTypeId, string lang)
        {
            try
            {
                db.DELETE_COMPANY_STORES(companyStoreId, teleTypeId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCompanyStore")]
        public IHttpActionResult GetCompanyStore(int classType, string lang)
        {
            try
            {
                var compantStore= db.SELECT_ALL_COMPANY_STORES(classType, lang);
                return Ok(compantStore);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCompanyStoreByCode")]
        public IHttpActionResult GetCompanyStoreByCode(string companyStoreCode, string lang)
        {
            try
            {
                var compantStore = db.SELECT_COMPANY_STORES_BY_CODE(companyStoreCode, lang);
                return Ok(compantStore);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }

    }
}
