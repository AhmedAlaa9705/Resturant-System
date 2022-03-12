using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using System.Data.Entity.Core;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class ItemsController : ApiController
    {
        private Smart1Entities4 db;
        public ItemsController()
        {
            db = Singleton.GetInstance();
        }
        [HttpPost]
        [Route("AddItem")]
        public IHttpActionResult AddItem(ITEM item, string groupCode, string masterUnit, string lang, string xmlUnit=null, string xmlCompany=null, string xmlMeasuring=null)
        {
            try
            {
                db.ADD_ITEMS(item.ITEM_CODE,
                    groupCode, item.ITEM_AR_NAME,
                    item.ITEM_EN_NAME,
                    item.ITEM_REMARKS,
                    item.PRODUCTION_DATE,
                    item.EXPIRED_DATE,
                    item.SERIAL_IN_INPUT,
                    item.SERIAL_IN_OUTPUT,
                    item.ITEM_PIC,
                    masterUnit, 
                    item.MIN_QTY,
                    item.ITEM_TYPE,
                    xmlUnit,
                    item.ITEM_COLOR,
                    item.ITEM_MODEL,
                    item.ITEM_BRAND,
                    item.COMPANY_ID,
                    item.SELLEDISCOUNT,
                    item.BURCHASEDISCOUNT,
                    item.DOESTHEQUANTITYISAPARTOFBARCODE,
                    item.QUANTITYLENGTHATTHEBARCODE,
                    item.QUANTITYSTARTATTHEBARCODE,
                    Convert.ToByte( item.COST_CALCULATION_TYPE),
                    item.SELLEDISCOUNTCASH,
                    item.BURCHASEDISCOUNTCASH,
                    item.GeneratePrices,
                    item.PART_NO,
                    item.QuantityDiscount,
                    item.QTY_FOR_DIS,
                    item.DIS_BY_QTY,
                    item.QTY_FOR_DIS2,
                    item.DIS_BY_QTY2,
                    item.PLACE_ID,
                    item.COPY_RIGHT,
                    item.ITEM_STOP,
                    item.NON_TAX ,
                    item.MARK_ID,
                    xmlCompany,
                    xmlMeasuring,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateItem")]
        public IHttpActionResult UpdateItem(ITEM item, string groupCode, string masterUnit , string lang, string xmlPrice=null, string xmlUnit=null, string xmlCompany=null, string xmlMeasuring=null)
        {
            try
            {
                db.MODIFY_ITEMS(item.ITEM_ID,
                    item.ITEM_CODE,
                    groupCode, item.ITEM_AR_NAME,
                    item.ITEM_EN_NAME,
                    item.ITEM_REMARKS,
                    item.PRODUCTION_DATE,
                    item.EXPIRED_DATE,
                    item.SERIAL_IN_INPUT,
                    item.SERIAL_IN_OUTPUT,
                    item.ITEM_PIC,
                    masterUnit,
                    item.MIN_QTY,
                    item.ITEM_TYPE,
                    xmlUnit,
                    xmlPrice,
                    
                    item.ITEM_COLOR,
                    item.ITEM_MODEL,
                    item.ITEM_BRAND,
                    item.COMPANY_ID,
                    item.SELLEDISCOUNT,
                    item.BURCHASEDISCOUNT,
                    item.DOESTHEQUANTITYISAPARTOFBARCODE,
                    item.QUANTITYLENGTHATTHEBARCODE,
                    item.QUANTITYSTARTATTHEBARCODE,
                    Convert.ToByte(item.COST_CALCULATION_TYPE),
                    item.SELLEDISCOUNTCASH,
                    item.BURCHASEDISCOUNTCASH,
                    item.GeneratePrices,
                    item.PART_NO,
                    item.QuantityDiscount,
                    item.QTY_FOR_DIS,
                    item.DIS_BY_QTY,
                    item.QTY_FOR_DIS2,
                    item.DIS_BY_QTY2,
                    item.PLACE_ID,
                    item.COPY_RIGHT,
                    item.ITEM_STOP,
                    item.NON_TAX,
                    item.MARK_ID,
                    xmlCompany,
                    xmlMeasuring,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("DeleteItem")]
        public IHttpActionResult DeleteItem(int itemId, string lang)
        {
            try
            {
                db.DELETE_ITEMS(itemId, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItems")]
        public IHttpActionResult GetItems(bool ISITORDEREDBYITEMCODEORNOT, bool NORMAL, string lang)
        {
            try
            {
                var items= db.SELECT_ALL_ITEMS(ISITORDEREDBYITEMCODEORNOT, lang,NORMAL);
                return Ok(items);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetUnitsAndPrices")]
        public IHttpActionResult GetUnitsAndPrices(int itemId, string lang)
        {
            try
            {
               var unip= db.SELECT_ALL_ITEMS_UNITS(itemId, lang);
                return Ok(unip);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItemsCompany")]
        public IHttpActionResult GetItemsCompany( string lang)
        {
            try
            {
                var itemsCompany = db.SELECT_ALL_ITEMS_COMPANIES( lang);
                return Ok(itemsCompany);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItemsCompanyWithItemId")]
        public IHttpActionResult GetItemsCompanyWithItemId(int itemId, string lang)
        {
            try
            {
                var model = (from item in db.ITEMS_COMPANY_ID
                             join account in db.ACCOUNTS
                             on item.COMPANY_ID equals account.ACC_ID
                             where item.ITEM_ID == itemId
                             select new
                             {
                                 accountId = account.ACC_ID,
                                 accCustomerCode = account.ACC_CUSTOMER_CODE,
                                 accArName = account.ACC_AR_NAME,
                                 tradeDis = item.TRADE_DIS,
                                 copyRight = item.COPYRIGHT,
                                 copyRightPublisher = item.COPYRIGHT_PUBLISHER,
                                 coIsDefault = item.CO_IS_DEFAULT

                             }).ToList();
                         


                return Ok(model);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItemByCode")]
        public IHttpActionResult GetItemByCode(string itemCode, string lang)
        {
            try
            {
                var itemcode = db.SELECT_ITEMS_BY_CODE(itemCode, lang);
                return Ok(itemcode);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetItemByGroup")]
        public IHttpActionResult GetItemByGroup(string groupId, string lang)
        {
            try
            {
                var itemgrop = db.SELECT_ITEMS_BY_GROUPID(groupId, lang);
                return Ok(itemgrop);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetCompanyByGroup")]
        public IHttpActionResult GetCompanyByGroup(string groupId, string lang)
        {
            try
            {
                var copmgrop = db.SELECT_COMPANY_BY_GROUPID(groupId, lang);
                return Ok(copmgrop);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
