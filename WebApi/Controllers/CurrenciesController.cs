using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class CurrenciesController : ApiController
    {
        private Smart1Entities4 db;
        public CurrenciesController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddCurrency")]
        public IHttpActionResult AddCurrency(CURRENCy currency, string lang)
        {
            try
            {
                db.ADD_CURRENCY(currency.CURRENCY_CODE,
                    currency.CURRENCY_AR_NAME,
                    currency.CURRENCY_EN_NAME,
                    currency.CURRENCY_SUB_AR_NAME,
                    currency.CURRENCY_SUB_EN_NAME,
                    currency.CURRENCY_RATE,
                    currency.SUB_TO_CURRENCY_TRANS,
                    currency.CURRENCY_FIXED_RATE,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateCurrency")]
        public IHttpActionResult UpdateCurrency(CURRENCy currency, string lang)
        {
            try
            {
                db.MODIFY_CURRENCY(currency.CURRENCY_ID, currency.CURRENCY_CODE,
                    currency.CURRENCY_AR_NAME,
                    currency.CURRENCY_EN_NAME,
                    currency.CURRENCY_SUB_AR_NAME,
                    currency.CURRENCY_SUB_EN_NAME, 
                    currency.CURRENCY_RATE,
                    currency.SUB_TO_CURRENCY_TRANS,
                    currency.CURRENCY_FIXED_RATE,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteCurrencyByCode")]
        public IHttpActionResult DeleteCurrencyByCode(string currencyCode, string lang)
        {
            try
            {
                db.DELETE_CURRENCY_BY_CODE(currencyCode, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteCurrencyById")]
        public IHttpActionResult DeleteCurrencyById(string currencyId, string lang)
        {
            try
            {
                db.DELETE_CURRENCY_BY_ID(currencyId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetAllCurrencies")]
        public IHttpActionResult GetAllCurrencies(string lang)
        {
            try
            {
                var curs= db.SELECT_ALL_CURRENCIES( lang);
                return Ok(curs);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCurrencyByCode")]
        public IHttpActionResult GetCurrencyByCode(string currencyCode, string lang)
        {
            try
            {
                var curs = db.SELECT_CURRENCY_BY_CODE(currencyCode, lang);
                return Ok(curs);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
     
        
    }
}
