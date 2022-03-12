using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class EmployeeTypesController : ApiController
    {
        private Smart1Entities4 db;
        public EmployeeTypesController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddEmpType")]
        public IHttpActionResult AddEmpType(EMPLOYEES_TYPES employeeType, string lang)
        {
            try
            {
                db.ADD_EMPLOYEE_TYPE(employeeType.EMP_TYPE_CODE,
                    employeeType.EMP_TYPE_AR_NAME,
                    employeeType.EMP_TYPE_EN_NAME,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateEmpType")]
        public IHttpActionResult UpdateEmpType(EMPLOYEES_TYPES employeeType, string lang)
        {
            try
            {
                db.MODIFY_EMPLOYEE_TYPE(employeeType.EMP_TYPE_ID,
                    employeeType.EMP_TYPE_CODE,
                    employeeType.EMP_TYPE_AR_NAME,
                    employeeType.EMP_TYPE_EN_NAME,
                    lang);
                return Ok();

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("DeleteEmpType")]
        public IHttpActionResult DeleteEmpType(byte empTypeId , string lang)
        {
            try
            {
                db.DELETE_EMPLOYEE_TYPE(empTypeId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeTypes")]
        public IHttpActionResult GetEmployeeTypes(string lang)
        {
            try
            {
                var emps= db.SELECT_ALL_EMP_TYPES(lang);
                return Ok(emps);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeTypeByCode")]
        public IHttpActionResult GetEmployeeTypeByCode(string empTypeCode, string lang)
        {
            try
            {
                var emps = db.SELECT_EMP_TYPES_BY_CODE(empTypeCode, lang);
                return Ok(emps);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeTypeById")]
        public IHttpActionResult GetEmployeeTypeById(byte empTypeId, string lang)
        {
            try
            {
                var emps = db.SELECT_EMP_TYPES_BY_ID(empTypeId, lang);
                return Ok(emps);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
