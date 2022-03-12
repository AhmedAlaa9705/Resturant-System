using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;
namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class ExpensesController : ApiController
    {
        private Smart1Entities4 db;
        public ExpensesController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddExpenses")]
        public IHttpActionResult AddExpenses(TEXPINSI texpini , string lang)
        {
            try
            {
                db.ADD_EXPINSIS(texpini.EXPINSIS_CODE,
                    texpini.EXPINSIS_AR_NAME, 
                    texpini.EXPINSIS_EN_NAME, 
                    texpini.EXPINSIS_ACCOUNT_ID.ToString(),
                    texpini.EXPINSIS_REMARKS,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
                
            }
        }
        [HttpPost]
        [Route("UpdateExpenses")]
        public IHttpActionResult UpdateExpenses(TEXPINSI texpini, string lang)
        {
            try
            {
                db.MODIFY_EXPINSIS(texpini.EXPINSIS_ID,
                    texpini.EXPINSIS_CODE,
                    texpini.EXPINSIS_AR_NAME,
                    texpini.EXPINSIS_EN_NAME, 
                    texpini.EXPINSIS_ACCOUNT_ID.ToString(),
                    texpini.EXPINSIS_REMARKS,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllExpenses")]
        public IHttpActionResult GetAllExpenses( string lang)
        {
            try
            {
              var expi=  db.SELECT_ALL_EXPINSIS(lang);
                return Ok(expi);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
