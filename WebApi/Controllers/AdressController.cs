using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApi.DAL;
using WebApi.AuthenticationFilters;
using WebApi.Singletons;

namespace WebApi.Controllers
{
    [BasicAuthenticationFilter]
    public class AdressController : ApiController
    {
        private Smart1Entities4 db;
        public AdressController()
        {
            db = Singleton.GetInstance();
        }
        [HttpGet]
        [Route("GetNation")]
        public IHttpActionResult GetNation(string lang)
        {
            try
            {
                var nations= db.SELECT_ALL_NATIONS(lang);
                return Ok(nations);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetGOVERNORATES")]
        public IHttpActionResult GetGov(short nationId,string lang)
        {
            try
            {
                var nations = db.SELECT_ALL_GOVERNORATES(nationId, lang);
                return Ok(nations);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetTown")]
        public IHttpActionResult GetTown(short govId,string lang)
        {
            try
            {
                var towns= db.SELECT_ALL_TOWNS(govId,lang);
                return Ok(towns);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetVillage")]
        public IHttpActionResult GetVillage(short towId, string lang)
        {
            try
            {
                var vilage= db.SELECT_ALL_VILLAGES(towId, lang);
                return Ok(vilage);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetTelephoneCat")]
        public IHttpActionResult GetTelephoneCat( string lang)
        {
            try
            {
                var telephones = db.SELECT_ALL_TELEPHONE_CAT( lang);
                return Ok(telephones);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetTelephones")]
        public IHttpActionResult GetTelephones(byte telTypeId,int teleId, string lang)
        {
            try
            {
                var telephone = db.SELECT_TELEPHONES(telTypeId,teleId, lang);
                return Ok(telephone);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetUnitName")]
        public IHttpActionResult GetUnitName(short unitId, string lang)
        {
            try
            {
                var unitName = db.SELECT_UNIT_NAME(unitId, lang);
                return Ok(unitName);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateNation")]
        public IHttpActionResult UpdateNation( NATION nation, string  lang)
        {
            try
            {
                 db.MODIFY_NATION(nation.NATION_ID,nation.NATION_AR_NAME,
                     nation.NATION_EN_NAME,
                     nation.NATIONALITY_AR_NAME,
                     nation.NATIONALITY_EN_NAME,
                     lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("AddNation")]
        public IHttpActionResult AddNation(NATION nation, string lang)
        {
            try
            {
                db.ADD_NATION(nation.NATION_AR_NAME,
                    nation.NATION_EN_NAME,
                    nation.NATIONALITY_AR_NAME,
                    nation.NATIONALITY_EN_NAME, 
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("AddGov")]
        public IHttpActionResult AddGov(GOVERNORATE gov, string lang)
        {
            try
            {
                db.ADD_GOV(gov.NATION_ID,gov.GOV_AR_NAME,gov.GOV_EN_NAME,lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateGov")]
        public IHttpActionResult UpdateGov(GOVERNORATE gov, string lang)
        {
            try
            {
                db.MODIFY_GOV(gov.GOV_ID, gov.GOV_AR_NAME, gov.GOV_EN_NAME, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("AddTown")]
        public IHttpActionResult AddTown(GOVERNORATE gov, string lang)
        {
            try
            {
                db.ADD_TOWN(gov.GOV_ID, gov.GOV_AR_NAME, gov.GOV_EN_NAME, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateTown")]
        public IHttpActionResult UpdateTown(TOWN tOWN, string lang)
        {
            try
            {
                db.MODIFY_TOWN(Convert.ToInt16( tOWN.TOWN_ID),tOWN.TOWN_AR_NAME,tOWN.TOWN_EN_NAME, lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("AddVillage")]
        public IHttpActionResult AddVillage(VILLAGE vILLAGE, string lang)
        {
            try
            {
                db.ADD_VILLAGE(Convert.ToInt16(vILLAGE.TOWN_ID),
                    vILLAGE.VILLAGE_AR_NAME,
                    vILLAGE.VILLAGE_EN_NAME,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("UpdateVillage")]
        public IHttpActionResult UpdateVillage(VILLAGE vILLAGE, string lang)
        {
            try
            {
                db.MODIFY_VILLAGE(Convert.ToInt16( vILLAGE.VILLAGE_ID),
                    vILLAGE.VILLAGE_AR_NAME,
                    vILLAGE.VILLAGE_EN_NAME,
                    lang);
                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);

            }
        }
    }
}
