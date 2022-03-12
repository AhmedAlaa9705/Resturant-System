using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class EntryController : ApiController
    {
        private Smart1Entities4 db;
        public EntryController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddEntry")]

        public IHttpActionResult AddEntry(ENTRY_MASTER entryMaster, string XML_DETAILS, int forKest, int costCenterId, string lang, string XML_PAY=null)
        {
            try
            {
                db.ADD_DAY_ENTRY(entryMaster.ENTRY_SETTING_ID,
                    entryMaster.ENTRY_NUMBER,
                    entryMaster.ENTRY_DATE,
                    entryMaster.ENTRY_CREDIT,
                    entryMaster.ENTRY_DEBIT,
                    entryMaster.ACC_ID,
                    entryMaster.CURRENCY_ID,
                    entryMaster.CURRENCY_RATE,
                    entryMaster.COLLECT_ENTRY_CODE,
                    entryMaster.IS_POSTED,
                    entryMaster.CHECK_NUMBER,
                    entryMaster.CHECK_DATE,
                    entryMaster.BILL_ID,
                    entryMaster.ENTRY_REMARKS,
                    entryMaster.EMP_ID,
                    XML_DETAILS,
                    entryMaster.for_kest,
                    costCenterId,
                    entryMaster.SHIFT_NUMBER,
                    entryMaster.COLLECT_NO,
                    entryMaster.TYPE_PAPER,
                    XML_PAY,
                    entryMaster.TYPE_CHECK,
                    entryMaster.BANK_NAME, 
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateEntry")]
        public IHttpActionResult UpdateEntry(ENTRY_MASTER entryMaster, string XML_DETAILS, int forKest, int costCenterId, string lang, string XML_PAY=null)
        {
            try
            {
                db.MODIFY_DAY_ENTRY(entryMaster.ENTRY_ID,
                    entryMaster.ENTRY_SETTING_ID,
                    entryMaster.ENTRY_NUMBER,
                    entryMaster.ENTRY_DATE, 
                    entryMaster.ENTRY_CREDIT,
                    entryMaster.ENTRY_DEBIT, 
                    entryMaster.ACC_ID,
                    entryMaster.CURRENCY_ID,
                    entryMaster.CURRENCY_RATE,
                    entryMaster.COLLECT_ENTRY_CODE,
                    entryMaster.IS_POSTED,
                    entryMaster.CHECK_NUMBER,
                    entryMaster.CHECK_DATE,
                    entryMaster.BILL_ID, 
                    entryMaster.ENTRY_REMARKS, 
                    entryMaster.EMP_ID,
                    XML_DETAILS,
                    entryMaster.for_kest,
                    costCenterId,
                    entryMaster.COLLECT_NO,
                    XML_PAY,
                    entryMaster.TYPE_PAPER,
                    entryMaster.TYPE_CHECK,
                    entryMaster.BANK_NAME, 
                    lang);
                return Ok();

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteEntry")]
        public IHttpActionResult DeleteEntry(long entryId, string lang)
        {
            try
            {
                db.DELETE_DAY_ENTRY(entryId, lang);
                return Ok();

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEntryData")]
        public IHttpActionResult GetEntryData(long entryId, string lang)
        {
            try
            {
                var entry= db.GET_ENTRY_MASTER(entryId, lang);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEntryId")]
        public IHttpActionResult GetEntryId(short entrySettingId, string lastEntryNumber)
        {
            try
            {
                var entry = db.GET_ENTRY_ID(entrySettingId,lastEntryNumber);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetLastEntryNumber")]
        public IHttpActionResult GetLastEntryNumber(short entrySettingId)
        {
            try
            {
                var entry = db.GET_LAST_ENTRY_NUMBER(entrySettingId);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetNextEntryId")]
        public IHttpActionResult GetNextEntryId(short entrySettingId, string lastEntryNumber)
        {
            try
            {
                var entry = db.GET_NEXT_ENTRY_ID(entrySettingId, lastEntryNumber);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetPreviousEntryId")]
        public IHttpActionResult GetPreviousEntryId(short entrySettingId, string lastEntryNumber)
        {
            try
            {
                var entry = db.GET_PREVIOUS_ENTRY_ID(entrySettingId, lastEntryNumber);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEntryMaster")]
        public IHttpActionResult GetAllEntryMaster(short entrySettingId, int number, long lastId, string lang)
        {
            try
            {
                var entry = db.GET_ALL_ENTRY_MASTER(entrySettingId, number, lastId, lang);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEntryDetails")]
        public IHttpActionResult GetAllEntryDetails(short entrySettingId, int number, long lastId, string lang)
        {
            try
            {
                var entry = db.GET_ALL_ENTRY_DETAILS(entrySettingId, number, lastId, lang);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("GenerateEntry")]
        public IHttpActionResult GenerateEntry(ENTRY_MASTER entryMaster, string XML_DETAILS, string currencyName, string postEntry, string lang)
        {
            try
            {
                var entry = db.GENERATE_ENTRY(currencyName,
                    entryMaster.CURRENCY_RATE,
                    postEntry, 
                    entryMaster.ENTRY_SETTING_ID,
                    entryMaster.ENTRY_DATE,
                    entryMaster.ENTRY_CREDIT,
                    entryMaster.ENTRY_DEBIT,
                    entryMaster.ACC_ID,
                    entryMaster.COLLECT_ENTRY_CODE,
                    entryMaster.IS_POSTED,
                    entryMaster.CHECK_NUMBER,
                    entryMaster.CHECK_DATE.ToString(),
                    entryMaster.ENTRY_REMARKS,
                    XML_DETAILS,
                    lang);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEntryDetailsCheck")]
        public IHttpActionResult GetAllEntryDetailsCheck(long checkEntryId)
        {
            try
            {
                var entry = db.GET_ENTRY_DETAILS_CHECK(checkEntryId);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEntryDetailsById")]
        public IHttpActionResult GetAllEntryDetailsById(long entryId, string lang)
        {
            try
            {
                var entry = db.GET_ENTRY_DETAILS(entryId, lang);
                return Ok(entry);

            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
