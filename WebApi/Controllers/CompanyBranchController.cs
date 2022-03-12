using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class CompanyBranchController : ApiController
    {
        private Smart1Entities4 db;
        public CompanyBranchController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddCompanyBranch")]
        public IHttpActionResult AddCompanyBranch(COMPANY_BRANCHES COMPANY_BRANCHES, byte teleTypeId, string lang, string xmlTelphones = null)
        {
            try
            {
                db.ADD_COMPANY_BRANCHES(COMPANY_BRANCHES.COM_BRN_CODE,
                    COMPANY_BRANCHES.COM_BRN_AR_NAME,
                    COMPANY_BRANCHES.COM_BRN_EN_NAME,
                    COMPANY_BRANCHES.COM_BRN_AR_ABRV,
                    COMPANY_BRANCHES.COM_BRN_EN_ABRV,
                    COMPANY_BRANCHES.NATION_ID,
                    COMPANY_BRANCHES.GOV_ID,
                    COMPANY_BRANCHES.TOWN_ID,
                    COMPANY_BRANCHES.VILLAGE_ID,
                    COMPANY_BRANCHES.COM_BRN_ADDR_REMARKS,
                    COMPANY_BRANCHES.COM_MASTER_BRN_ID.ToString(),
                    COMPANY_BRANCHES.COM_BRN_REMARKS,
                    COMPANY_BRANCHES.COST_CENTER_ID,
                    COMPANY_BRANCHES.ACC_PAY_ID,
                    teleTypeId,
                    xmlTelphones,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateCompanyBranch")]
        public IHttpActionResult UpdateCompanyBranch(COMPANY_BRANCHES COMPANY_BRANCHES, byte teleTypeId, string lang, string xmlTelphones=null)
        {
            try
            {
                db.MODIFY_COMPANY_BRANCHES(COMPANY_BRANCHES.COM_BRN_ID,
                    COMPANY_BRANCHES.COM_BRN_CODE,
                    COMPANY_BRANCHES.COM_BRN_AR_NAME,
                    COMPANY_BRANCHES.COM_BRN_EN_NAME,
                    COMPANY_BRANCHES.COM_BRN_AR_ABRV,
                    COMPANY_BRANCHES.COM_BRN_EN_ABRV,
                    COMPANY_BRANCHES.NATION_ID,
                    COMPANY_BRANCHES.GOV_ID,
                    COMPANY_BRANCHES.TOWN_ID,
                    COMPANY_BRANCHES.VILLAGE_ID,
                    COMPANY_BRANCHES.COM_BRN_ADDR_REMARKS,
                    COMPANY_BRANCHES.COM_MASTER_BRN_ID.ToString(),
                    COMPANY_BRANCHES.COM_BRN_REMARKS,
                    COMPANY_BRANCHES.COST_CENTER_ID,
                    COMPANY_BRANCHES.ACC_PAY_ID,
                    teleTypeId,
                    xmlTelphones,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteCompanyBranch")]
        public IHttpActionResult DeleteCompanyBranch(short companyBranchId, byte teleTypeId, string lang)
        {
            try
            {
                db.DELETE_COMPANY_BRANCHES(companyBranchId,teleTypeId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCompanyBranch")]
        public IHttpActionResult GetCompanyBranch( string lang)
        {
            try
            {
                var comps= db.SELECT_ALL_COMPANY_BRANCHES(lang);
                return Ok(comps);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCompanyBranchByCode")]
        public IHttpActionResult GetCompanyBranchByCode(string companyBranchCode, string lang)
        {
            try
            {
                var copByCode= db.SELECT_COMPANY_BRANCHES_BY_CODE(companyBranchCode, lang);
                return Ok(copByCode);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
