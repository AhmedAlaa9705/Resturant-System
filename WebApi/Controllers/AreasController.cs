using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class AreasController : ApiController
    {
        private Smart1Entities4 db;
        public AreasController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddArea")]
        public IHttpActionResult AddArea(AREA area,string lang)
        {
            try
            {
                db.ADD_AREAS(area.AREA_CODE, area.AREA_AR_NAME, area.AREA_EN_NAME, area.AREA_REMARKS,lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        //public IHttpActionResult UpdateArea(AREA area, string lang)
        //{
        //    try
        //    {
        //        db.MODIFY_AREAS(area.AREA_CODE, area.AREA_AR_NAME, area.AREA_EN_NAME, area.AREA_REMARKS, lang);
        //        return Ok();
        //    }
        //    catch (EntityCommandExecutionException ex)
        //    {

        //        return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

        //    }
        //}
        //public IHttpActionResult DeleteArea(AREA area, string lang)
        //{
        //    try
        //    {
        //        db.DELETE_AREAS(area.AREA_CODE, area.AREA_AR_NAME, area.AREA_EN_NAME, area.AREA_REMARKS, lang);
        //        return Ok();
        //    }
        //    catch (EntityCommandExecutionException ex)
        //    {

        //        return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

        //    }
        //}
        [HttpGet]
        [Route("GetAreas")]
        public IHttpActionResult GetAreas(string lang)
        {
            try
            {
                var areas= db.SELECT_ALL_AREAS(lang);
                return Ok(areas);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        //public IHttpActionResult GetAreaByCode(string areaCode, string lang)
        //{
        //    try
        //    {
        //        var areas = db.SELECT_AREAS_BY_CODE(areaCode, lang);
        //        return Ok(areas);
        //    }
        //    catch (EntityCommandExecutionException ex)
        //    {

        //        return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

        //    }
        //}
    }
}
