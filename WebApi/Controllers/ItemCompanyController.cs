using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;
namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class ItemCompanyController : ApiController
    {
        private Smart1Entities4 db;
        public ItemCompanyController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddItemCompany")]
        public IHttpActionResult AddItemCompany(ITEMS_COMPANIES itemCompanies, string lang)
        {
            try
            {
                db.ADD_ITEMS_COMPANIES(itemCompanies.COMPANY_CODE,
                    itemCompanies.COMPANY_AR_NAME,
                    itemCompanies.COMPANY_EN_NAME,
                    itemCompanies.COMPANY_REMARKS, 
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateItemCompany")]
        public IHttpActionResult UpdateItemCompany(ITEMS_COMPANIES itemCompanies, string lang)
        {
            try
            {
                db.MODIFY_ITEMS_COMPANIES(itemCompanies.COMPANY_ID,
                    itemCompanies.COMPANY_CODE,
                    itemCompanies.COMPANY_AR_NAME,
                    itemCompanies.COMPANY_EN_NAME,
                    itemCompanies.COMPANY_REMARKS, 
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteItemCompany")]
        public IHttpActionResult DeleteItemCompany(int companyId, string lang)
        {
            try
            {
                db.DELETE_ITEMS_COMPANIES(companyId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItemCompanies")]
        public IHttpActionResult GetItemCompanies(string lang)
        {
            try
            {
                var itemcompany= db.SELECT_ALL_ITEMS_COMPANIES(lang);
                return Ok(itemcompany);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItemCompanyByCode")]
        public IHttpActionResult GetItemCompanyByCode(string companyCode, string lang)
        {
            try
            {
                var itemcompanyCode = db.SELECT_ITEMS_COMPANIES_BY_CODE(companyCode, lang);
                return Ok(itemcompanyCode);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
