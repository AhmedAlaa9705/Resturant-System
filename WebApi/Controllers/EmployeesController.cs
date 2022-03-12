using System;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.Singletons;
using WebApi.AuthenticationFilters;

namespace WebApi.Controllers
{
     [BasicAuthenticationFilter]
    public class EmployeesController : ApiController
    {
        private Smart1Entities4 db;
        public EmployeesController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IHttpActionResult AddEmployee(EMPLOYEE employee, string lang, string xmlTelephones)
        {
            try
            {
                db.ADD_EMPLOYEE(employee.EMP_CODE,
                    employee.EMP_AR_NAME,
                    employee.EMP_EN_NAME,
                    employee.EMP_NATIONAL_ID,
                    employee.ACC_ID,
                    employee.EMP_TYPE_ID,
                    employee.COM_BRN_ID,
                    employee.DEPT_ID,
                    employee.EMP_BARCODE,
                    employee.EMP_BARCODE_IMAGE,
                    employee.EMP_PHOTO,
                    employee.EMP_REMARKS,
                    employee.NATIONALITY_ID,
                    employee.NATION_ID,
                    employee.GOV_ID,
                    employee.TOWN_ID,
                    Convert.ToInt32( employee.VILLAGE_ID),
                    employee.EMP_ADDR_REMARKS,
                    xmlTelephones,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateEmployee")]
        public IHttpActionResult UpdateEmployee(EMPLOYEE employee, string lang, string xmlTelephones)
        {
            try
            {
                db.MODIFY_EMPLOYEE(employee.EMP_ID,
                    employee.EMP_CODE,
                    employee.EMP_AR_NAME,
                    employee.EMP_EN_NAME,
                    employee.EMP_NATIONAL_ID,
                    employee.ACC_ID,
                    employee.EMP_TYPE_ID,
                    employee.COM_BRN_ID,
                    employee.DEPT_ID,
                    employee.EMP_BARCODE,
                    employee.EMP_BARCODE_IMAGE,
                    employee.EMP_PHOTO,
                    employee.EMP_REMARKS,
                    employee.NATIONALITY_ID,
                    employee.NATION_ID,
                    employee.GOV_ID,
                    employee.TOWN_ID,
                    Convert.ToInt32(employee.VILLAGE_ID),
                    employee.EMP_ADDR_REMARKS,
                    xmlTelephones,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteEmployee")]
        public IHttpActionResult DeleteEmployee(short employeeId, string lang)
        {
            try
            {
                db.DELETE_EMPLOYEE(employeeId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeByName")]
        public IHttpActionResult GetEmployeeByName(string employeeName, string lang)
        {
            try
            {
                var empName= db.SELECT_EMPLOYEES_BY_NAME(employeeName, lang);
                return Ok(empName);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeByComBrn")]
        public IHttpActionResult GetEmployeeByComBrn(int companyBranchId, string lang)
        {
            try
            {
                var empcomBrn = db.SELECT_EMPLOYEES_BY_COM_BRN(companyBranchId, lang);
                return Ok(empcomBrn);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeByDept")]
        public IHttpActionResult GetEmployeeByDept(int deptId, string lang)
        {
            try
            {
                var empcomBrn = db.SELECT_EMPLOYEES_BY_DEPT(deptId, lang);
                return Ok(empcomBrn);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeByType")]
        public IHttpActionResult GetEmployeeByType(byte typeId, string lang)
        {
            try
            {
                var empByType = db.SELECT_EMPLOYEES_BY_TYPE(typeId, lang);
                return Ok(empByType);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("_GetEmployeeByCode")]
        public IHttpActionResult _GetEmployeeByCode(string empCode, string lang)
        {
            try
            {
                var empByCode = db.SELECT_EMPLOYEES_BY_CODE(empCode, lang);
                return Ok(empByCode);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEmployeeById")]
        public IHttpActionResult GetEmployeeById(short empId, string lang)
        {
            try
            {
                var empByCode = db.SELECT_EMPLOYEES_BY_ID(empId, lang);
                return Ok(empByCode);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEmployees")]
        public IHttpActionResult GetAllEmployees( string lang)
        {
            try
            {
                var emps = db.GET_ALL_EMPLOYEE(lang);
                return Ok(emps);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }

    }
}
