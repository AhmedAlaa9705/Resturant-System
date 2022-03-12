using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class LogFileController : ApiController
    {
        private Smart1Entities4 db;
        public LogFileController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddToLogFile")]
        public IHttpActionResult AddToLogFile(UserLogFile userLogFile)
        {
            try
            {
                db.InsertIntoUserLogFile(userLogFile.UID, 
                    userLogFile.FormName,
                    userLogFile.OpName,
                    userLogFile.OpDate,
                    userLogFile.Notes,
                    userLogFile.DateOnly,
                    userLogFile.ALL_ID);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteUserLogFile")]
        public IHttpActionResult DeleteUserLogFile(string UID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                db.DeleteUserLogFile(UID, fromDate, toDate);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetOpOfUser")]
        public IHttpActionResult GetOpOfUser(string UID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                var log= db.GetLogForUIDInPeriod(UID, fromDate, toDate);
                return Ok(log);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
          
        }
        [HttpGet]
        [Route("GetOpOnForm")]
        public IHttpActionResult GetOpOnForm(string formName, string UID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                var loog= db.GetLogForFormInPeriod(formName,UID, fromDate, toDate);
                return Ok(loog);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
