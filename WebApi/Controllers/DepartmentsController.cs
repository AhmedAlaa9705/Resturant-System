using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;
namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class DepartmentsController : ApiController
    {
        private Smart1Entities4 db;
        public DepartmentsController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddDepartment")]
        public IHttpActionResult AddDepartment(DEPARTMENT dept, string lang)
        {
            try
            {
                db.ADD_DEPARTMENT(dept.DEPT_CODE,
                    dept.DEPT_AR_NAME,
                    dept.DEPT_EN_NAME,
                    dept.DEPT_AR_ABRV,
                    dept.DEPT_EN_NAME,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateDepartment")]
        public IHttpActionResult UpdateDepartment(DEPARTMENT dept, string lang)
        {
            try
            {
                db.MODIFY_DEPARTMENT(dept.DEPT_ID,
                    dept.DEPT_CODE,
                    dept.DEPT_AR_NAME, 
                    dept.DEPT_EN_NAME, 
                    dept.DEPT_AR_ABRV,
                    dept.DEPT_EN_NAME, 
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteDepartment")]
        public IHttpActionResult DeleteDepartment(short deptId , string lang)
        {
            try
            {
                db.DELETE_DEPARTMENT(deptId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetDepartment")]
        public IHttpActionResult GetDepartment(string lang)
        {
            try
            {
                var depts= db.SELECT_ALL_DEPARTMENTS(lang);
                return Ok(depts);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetDepartmentByCode")]  
        public IHttpActionResult GetDepartmentByCode(string deptCode, string lang)
        {
            try
            {
                db.SELECT_DEPARTMENT_BY_CODE(deptCode, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
