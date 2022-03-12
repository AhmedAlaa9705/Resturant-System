using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;
namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class ServiceGroupController : ApiController
    {
        private Smart1Entities4 db;
        public ServiceGroupController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddServiceGroup")]
        public IHttpActionResult AddServiceGroup(SERVICE_GROUP serviceGroup)
        {
            try
            {
                db.ADD_SERVICE_GROUPS(serviceGroup.S_GROUP_CODE.ToString(), serviceGroup.S_GROUP_NAME, serviceGroup.S_GROUP_MASTER_ID, serviceGroup.S_GROUP_REMARKS);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateServiceGroup")]
        public IHttpActionResult UpdateServiceGroup(SERVICE_GROUP serviceGroup)
        {
            try
            {
                db.MODIFY_SERVICE_GROUPS(serviceGroup.S_GROUP_ID, serviceGroup.S_GROUP_CODE.ToString(), serviceGroup.S_GROUP_NAME, serviceGroup.S_GROUP_MASTER_ID, serviceGroup.S_GROUP_REMARKS);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteServiceGroup")]
        public IHttpActionResult DeleteServiceGroup(int serviceGroupId)
        {
            try
            {
                db.DELETE_SERVICE_GROUPS(serviceGroupId);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetServiceGroups")]
        public IHttpActionResult GetServiceGroups()
        {
            try
            {
                var servis= db.SELECT_ALL_SERVICE_GROUPS();
                return Ok(servis);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }

    }
}
