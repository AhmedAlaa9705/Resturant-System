using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;


namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class CostCenterController : ApiController
    {
        private Smart1Entities4 db;
        public CostCenterController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddCostCenter")]
        public IHttpActionResult AddCostCenter(COST_CENTERS COST_CENTERS, string lang)
        {
            try
            {
                db.ADD_COST_CENTERS(COST_CENTERS.COST_CENTER_CODE,
                    COST_CENTERS.COST_CENTER_AR_NAME,
                    COST_CENTERS.COST_CENTER_EN_NAME,
                    COST_CENTERS.COST_CENTER_MASTER_ID.ToString(),
                    COST_CENTERS.COST_CENTER_REMARKS,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateCostCenter")]
        public IHttpActionResult UpdateCostCenter(COST_CENTERS COST_CENTERS, string lang)
        {
            try
            {
                db.MODIFY_COST_CENTERS(COST_CENTERS.COST_CENTER_ID,
                    COST_CENTERS.COST_CENTER_CODE,
                    COST_CENTERS.COST_CENTER_AR_NAME,
                    COST_CENTERS.COST_CENTER_EN_NAME,
                    COST_CENTERS.COST_CENTER_MASTER_ID.ToString(),
                    COST_CENTERS.COST_CENTER_REMARKS,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteCostCenter")]
        public IHttpActionResult DeleteCostCenter(int costCenterId, string lang)
        {
            try
            {
                db.DELETE_COST_CENTERS(costCenterId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }

        }
        [HttpGet]
        [Route("GetAllCostCenter")]
        public IHttpActionResult GetAllCostCenter(string lang)
        {
            try
            {
               var cosCenter= db.SELECT_ALL_COST_CENTERS(lang);
                return Ok(cosCenter);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCostCenterByCode")]
        public IHttpActionResult GetCostCenterByCode(string costCenterCode, string lang)
        {
            try
            {
                var cosCenter = db.SELECT_COST_CENTERS_BY_CODE(costCenterCode, lang);
                return Ok(cosCenter);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }

    }
}
