using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;
namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class EntrySettingsController : ApiController
    {
      
        private Smart1Entities4 db;
        public EntrySettingsController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddEntrySettings")]
        public IHttpActionResult AddEntrySettings([FromBody]ENTRY_SETTINGS entrySettings, [FromBody]ENTRY_GRID_COLUMNS entryGridColumns, [FromUri]string lang)
        {
            try
            {
                db.ADD_ENTRY_SETTING(entrySettings.ENTRY_SETTING_AR_NAME,
                    entrySettings.ENTRY_SETTING_EN_NAME,
                    entrySettings.ENTRY_SETTING_AR_ABRV,
                    entrySettings.ENTRY_SETTING_EN_ABRV,
                    entrySettings.ENTRY_ACC_ID,
                    entrySettings.CURRENCY_ID,
                    entrySettings.AUTO_POSTING,
                    entrySettings.ENTRY_TYPE_ID,
                    entrySettings.ACCEPT_DIST_ACC,
                    entrySettings.COSTCENTER_BELONG,
                    entrySettings.PRINT_AS_RESET,
                    entrySettings.SHOW_THE_LAST_BALANCE,
                    entrySettings.NUMBEROFCOPIES,
                    entryGridColumns.CREDIT_INDEX,
                    entryGridColumns.CREDIT_WIDTH,
                    entryGridColumns.DEBIT_COLOR,
                    entryGridColumns.DEBIT_INDEX,
                    entryGridColumns.DEBIT_WIDTH,
                    entryGridColumns.DEBIT_COLOR,
                    entryGridColumns.ACC_INDEX,
                    entryGridColumns.ACC_WIDTH,
                    entryGridColumns.ACC_COLOR,
                    entryGridColumns.COST_CENTER_INDEX,
                    entryGridColumns.COST_CENTER_WIDTH,
                    entryGridColumns.COST_CENTER_COLOR,
                    entryGridColumns.REMARKS_INDEX,
                    entryGridColumns.REMARKS_WIDTH,
                    entryGridColumns.REMARKS_COLOR,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateEntrySettings")]
        public IHttpActionResult UpdateEntrySettings(ENTRY_SETTINGS entrySettings, ENTRY_GRID_COLUMNS entryGridColumns, string lang)
        {
            try
            {
                db.MODIFY_ENTRY_SETTING(entrySettings.ENTRY_SETTING_ID,
                    entrySettings.ENTRY_SETTING_AR_NAME,
                    entrySettings.ENTRY_SETTING_EN_NAME,
                    entrySettings.ENTRY_SETTING_AR_ABRV,
                    entrySettings.ENTRY_SETTING_EN_ABRV,
                    entrySettings.ENTRY_ACC_ID,
                    entrySettings.CURRENCY_ID,
                    entrySettings.AUTO_POSTING, 
                    entrySettings.ENTRY_TYPE_ID,
                    entrySettings.ACCEPT_DIST_ACC,
                    entrySettings.COSTCENTER_BELONG,
                    entrySettings.PRINT_AS_RESET,
                    entrySettings.SHOW_THE_LAST_BALANCE, 
                    entrySettings.NUMBEROFCOPIES, 
                    entryGridColumns.CREDIT_INDEX,
                    entryGridColumns.CREDIT_WIDTH,
                    entryGridColumns.DEBIT_COLOR,
                    entryGridColumns.DEBIT_INDEX, 
                    entryGridColumns.DEBIT_WIDTH,
                    entryGridColumns.DEBIT_COLOR,
                    entryGridColumns.ACC_INDEX,
                    entryGridColumns.ACC_WIDTH, 
                    entryGridColumns.ACC_COLOR, 
                    entryGridColumns.COST_CENTER_INDEX,
                    entryGridColumns.COST_CENTER_WIDTH,
                    entryGridColumns.COST_CENTER_COLOR,
                    entryGridColumns.REMARKS_INDEX,
                    entryGridColumns.REMARKS_WIDTH,
                    entryGridColumns.REMARKS_COLOR,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteEntrySettinsgs")]
        public IHttpActionResult DeleteEntrySettinsgs(short entrySettingId, string lang)
        {
            try
            {
                db.DELETE_ENTRY_SETTING(entrySettingId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
           
        }
        [HttpGet]
        [Route("GetEntrySettingsById")]
        public IHttpActionResult GetEntrySettingsById(short entrySettingId, string lang)
        {
            try
            {
                var entry= db.GET_ENTRY_SETTING(entrySettingId, lang);
                return Ok(entry);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEntrySettingsByAbbrev")]
        public IHttpActionResult GetEntrySettingsByAbbrev(string entrySettingAbrv, string lang)
        {
            try
            {
                var entry = db.GET_ENTRY_SETTING_BY_ABRV(entrySettingAbrv, lang);
                return Ok(entry);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetEntrySettingsByName")]
        public IHttpActionResult GetEntrySettingsByName(string entrySettingName, string lang)
        {
            try
            {
                var entry = db.GET_ENTRY_SETTING_BY_NAME(entrySettingName, lang);
                return Ok(entry);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEntrySettings")]
        public IHttpActionResult GetAllEntrySettings(string lang)
        {
            try
            {
                var entry = db.GET_ALL_ENTRY_SETTING( lang);
                return Ok(entry);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllEntrySettingsTypes")]
        public IHttpActionResult GetAllEntrySettingsTypes()
        {
            try
            {
                var entry = db.GET_ALL_ENTRY_TYPES();
                return Ok(entry);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
