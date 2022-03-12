using System;
using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class BoxController : ApiController
    {
        private Smart1Entities4 db;
        public BoxController()
        {
            db = Singleton.GetInstance();
        }

        [HttpPost]
        [Route("AddBox")]
        public IHttpActionResult AddBox(TBOX box,string lang)
        {
            try
            {
                db.ADD_BOX(box.BOX_CODE,
                    box.BOX_AR_NAME,
                    box.BOX_EN_NAME,
                    box.BOX_ACCOUNT_ID.ToString(),
                    box.BOX_REMARKS,
                    Convert.ToInt32( box.BOX_OR_BANK),
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("UpdateBox")]
        public IHttpActionResult UpdateBox(TBOX box, string lang)
        {
            try
            {
                db.MODIFY_BOX(box.BOX_ID,
                    box.BOX_CODE,
                    box.BOX_AR_NAME,
                    box.BOX_EN_NAME,
                    box.BOX_ACCOUNT_ID.ToString(),
                    box.BOX_REMARKS,
                    box.BOX_OR_BANK,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetAllBoxss")]
        public IHttpActionResult GetAllBox(byte type, string lang)
        {
            try
            {
                var boxes= db.SELECT_ALL_BOX(type, lang);
                return Ok(boxes);
            }
            catch (EntityCommandExecutionException ex)
            {
                   return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
    }
}
