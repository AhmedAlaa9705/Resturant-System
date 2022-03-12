using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class FollowProductionsController : ApiController
    {
        private Smart1Entities4 db;
        public FollowProductionsController()
        {
            db = Singleton.GetInstance();
        }

        [HttpPost]
        [Route("AddFollowProduction")]
        public IHttpActionResult AddFollowProduction(TFOLLOW_PRODUCTION fOLLOW_PRODUCTION, string lang, string xmlData=null)
        {
            try
            {
                db.ADD_FOLLOWPRODUCT_MASTER(fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_CODE,
                    fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_DATE,
                    fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_NOTES,
                    xmlData,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateFollowProduction")]
        public IHttpActionResult UpdateFollowProduction(TFOLLOW_PRODUCTION fOLLOW_PRODUCTION, string lang, string xmlData=null)
        {
            try
            {
                db.UPDATE_FOLLOWPRODUCT_MASTER(fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_ID,
                    fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_CODE,
                    fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_DATE,
                    fOLLOW_PRODUCTION.FOLLOW_PRODUCTION_NOTES,
                    xmlData,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteFollowProduction")]
        public IHttpActionResult DeleteFollowProduction(int followProductionId, string lang, string xmlData=null)
        {
            try
            {
                db.DELETE_FOLLOWPRODUCT_MASTER(followProductionId,xmlData, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        //public IHttpActionResult GetAllFollowProduction(string lang)
        //{
        //    try
        //    {
        //        db.SELECT_ALL_FOLLOWS(lang);
        //        return Ok();
        //    }
        //    catch (EntityCommandExecutionException ex)
        //    {

        //        return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

        //    }
        //}
        //public IHttpActionResult GetFollowProductionById(int followProductionId, string lang)
        //{
        //    try
        //    {
        //        db.SELECT_ALL_FOLLOWS_DETAILS(lang);
        //        return Ok();
        //    }
        //    catch (EntityCommandExecutionException ex)
        //    {

        //        return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

        //    }
        //}
    }
}
