using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;
using WebApi.AuthenticationFilters;
using WebApi.DAL;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class UnitsController : ApiController
    {
        private readonly Smart1Entities4 db;
        public UnitsController()
        {
            db = Singleton.GetInstance();
        }
        [HttpGet ]
        [Route("AllUnits")]
        public IHttpActionResult Get(string lang)
        {
            var units = db.SELECT_ALL_UNITS(lang);
            return Ok(units);
        }
        [HttpGet, ActionName("GetUnitsByCode")]
        [Route("GetUnitsByCode")]
        public IHttpActionResult GetUnitsByCode(string unitCode, string lang)
        {
            try
            {
                var units = db.SELECT_UNITS_BY_CODE(unitCode, lang);

                return Ok(units);
            }
            catch (EntityCommandExecutionException ex)
            {
                return Content(HttpStatusCode.NotFound, ex.InnerException.Message);
            }

        }
        [HttpPost, ActionName("Add")]
        [Route("AddUnits")]
        public IHttpActionResult Add(UNIT unit, string lang)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var err = db.ADD_UNITS(unit.UNIT_CODE, 
                        unit.UNIT_AR_NAME,
                        unit.UNIT_EN_NAME,
                        unit.UNIT_REMARKS, 
                        lang.Trim());

                    return Created(Request.RequestUri + unit.ToString(), "تم الاضافه بنجاح");
                }
                else
                {
                    return BadRequest();
                }


            }
            catch (EntityCommandExecutionException ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }

        }
        [HttpPost, ActionName("Update")]
        [Route("UpdateUnits")]

        public IHttpActionResult Update([FromBody] UNIT unit, string lang)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.MODIFY_UNITS(unit.UNIT_ID, 
                        unit.UNIT_CODE, 
                        unit.UNIT_AR_NAME,
                        unit.UNIT_EN_NAME,
                        unit.UNIT_REMARKS, 
                        lang);

                    return Ok("تم التعديل بنجاح");

                }
                else
                {
                    return BadRequest();
                }
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }



        }
        [HttpDelete]
        public IHttpActionResult Delete(UNIT unit, string lang)
        {
            try
            {
                var err = db.DELETE_UNITS(unit.UNIT_ID, lang);
                if (err == 0)
                {
                    return Ok("كود الوحدة غير موجود");

                }
                return Ok("تم الحذف بنجاح");

            }
            catch (EntityCommandExecutionException ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }

        }
    }
}
