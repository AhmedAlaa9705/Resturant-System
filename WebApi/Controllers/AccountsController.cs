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
    public class AccountsController : ApiController
    {
        private readonly Smart1Entities4 db;
        private readonly CUSTOMER customer;

        public AccountsController()
        {
            db = Singleton.GetInstance();
            customer = new CUSTOMER();
        }

        [HttpPost]
        public IHttpActionResult AddAccount( ACCOUNT account, string lang)
        {
            try
            {

                if (account.ACC_TYPE_ID == 2)
                {

                    db.ADD_FINAL_ACCOUNT(
                        account.ACC_CODE,
                        account.ACC_AR_NAME,
                        account.ACC_EN_NAME,
                        account.ACC_DATE,
                        account.ACC_CHECK_DATE,
                        account.ACC_STATE,
                        account.ACC_CREDIT,
                        account.ACC_DEBIT,
                        account.ACC_MAX_DEBIT,
                        account.CURRENCY_ID,
                        account.PARENT_ACC_ID,
                        account.FINAL_ACC_ID,
                        account.ACC_LEVEL,
                        account.ACC_REMARKS,
                        account.ACC_NSONS,
                        account.ACC_TURNNING_YES_OR_NO,
                        lang);
                }
                else if (account.ACC_TYPE_ID == 1)
                {

                    var x = db.ADD_NORMAL_ACCOUNT(
                        account.ACC_CODE,
                        account.ACC_AR_NAME,
                        account.ACC_EN_NAME,
                        account.ACC_TYPE_ID,
                        account.ACC_DATE,
                        account.ACC_CHECK_DATE,
                        account.ACC_STATE,
                        account.ACC_CREDIT,
                        account.ACC_DEBIT,
                        account.ACC_MAX_DEBIT,
                        account.CURRENCY_ID,
                        account.PARENT_ACC_ID,
                        account.FINAL_ACC_ID,
                        account.ACC_LEVEL,
                        account.ACC_REMARKS,
                        account.ACC_NSONS,
                        account.ACC_DEBIT_OR_CREDIT_OR_WITHOUT,
                        lang, account.ACC_MUST_COST_CENTER);

                }
                else if (account.ACC_TYPE_ID == 3)
                {

                    db.ADD_COLLECTIVE_ACCOUNT(account.ACC_CODE,
                          account.ACC_AR_NAME,
                          account.ACC_EN_NAME, account.ACC_TYPE_ID, account.ACC_DATE,
                          account.ACC_CHECK_DATE,
                          account.ACC_STATE,
                          account.ACC_CREDIT,
                          account.ACC_DEBIT,
                          account.ACC_MAX_DEBIT,
                          account.CURRENCY_ID,
                          account.PARENT_ACC_ID,
                          account.FINAL_ACC_ID,
                          account.ACC_LEVEL,
                          account.ACC_REMARKS,
                          account.ACC_NSONS,

                          lang);
                }
                else if (account.ACC_TYPE_ID == 4)
                {
                    db.ADD_DISTRIBUTIVE_ACCOUNT(account.ACC_CODE,
                             account.ACC_AR_NAME,
                             account.ACC_EN_NAME, account.ACC_TYPE_ID, account.ACC_DATE,
                             account.ACC_CHECK_DATE,
                             account.ACC_STATE,
                             account.ACC_CREDIT,
                             account.ACC_DEBIT,
                             account.ACC_MAX_DEBIT,
                             account.CURRENCY_ID,
                             account.PARENT_ACC_ID,
                             account.FINAL_ACC_ID,
                             account.ACC_LEVEL,
                             account.ACC_REMARKS,
                             account.ACC_NSONS,
                             lang);
                }
                else if (account.ACC_TYPE_ID == 7)
                {
                    db.ADD_NORMAL_CUSTOMER_OR_SUPPLIER_ACCOUNT(account.ACC_CODE,
                               account.ACC_AR_NAME,
                               account.ACC_EN_NAME,
                               account.ACC_TYPE_ID,
                               account.ACC_DATE,
                               account.ACC_CHECK_DATE,
                               account.ACC_STATE,
                               account.ACC_CREDIT,
                               account.ACC_DEBIT,
                               account.ACC_MAX_DEBIT,
                               account.CURRENCY_ID,
                               account.PARENT_ACC_ID,
                               account.FINAL_ACC_ID,
                               account.ACC_LEVEL,
                               account.ACC_REMARKS,
                               account.ACC_NSONS,
                               account.ACC_TURNNING_YES_OR_NO,
                               account.ACC_DEBIT_OR_CREDIT_OR_WITHOUT,
                               customer.NATIONALITY_ID,
                               customer.NATION_ID,
                               customer.GOV_ID,
                               customer.TOWN_ID,
                              Convert.ToInt32(customer.VILLAGE_ID),
                               customer.CUST_ADDR_REMARKS,
                               customer.CUST_EMAIL,
                               customer.CUST_WEB_SITE,
                               customer.CUST_PHOTO,
                               customer.CUST_ZIP_CODE,
                               customer.CUST_POST_BOX,
                               customer.SELL_TYPE_ID,
                               lang,
                               account.ACC_CUSTOMER_CODE,
                               customer.SHASIHNUMBER,
                               customer.ENGINENUMBER,
                               customer.CARMETERVALUE,
                               customer.CARNUMBER,
                               customer.EMP_ID,
                               customer.ROUTA,
                               customer.TOTAL_DISC,
                               customer.GROUP_DISC,
                               customer.BILL_PAY_TYPE,
                               customer.AREA_ID,
                               customer.COM_BRN_ID,
                               account.ACC_MUST_COST_CENTER);
                }
                else
                {
                    db.ADD_NORMAL_ACCOUNT(
                            account.ACC_CODE,
                            account.ACC_AR_NAME,
                            account.ACC_EN_NAME,
                            account.ACC_TYPE_ID,
                            account.ACC_DATE,
                            account.ACC_CHECK_DATE,
                            account.ACC_STATE,
                            account.ACC_CREDIT,
                            account.ACC_DEBIT,
                            account.ACC_MAX_DEBIT,
                            account.CURRENCY_ID,
                            account.PARENT_ACC_ID,
                            account.FINAL_ACC_ID,
                            account.ACC_LEVEL,
                            account.ACC_REMARKS,
                            account.ACC_NSONS,
                            account.ACC_DEBIT_OR_CREDIT_OR_WITHOUT,
                            lang, account.ACC_MUST_COST_CENTER);
                }

                return Ok();
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            
        }
        [HttpPut]
        public IHttpActionResult UpdateAccount(ACCOUNT account, string lang)
        {
            try
            {
                if (account.ACC_TYPE_ID==1)
                {
                    db.MODIFY_NORMAL_ACCOUNT(account.ACC_ID, account.ACC_CODE,
                     account.ACC_AR_NAME,
                     account.ACC_EN_NAME,
                     account.ACC_DATE,
                     account.ACC_STATE,
                     account.ACC_MAX_DEBIT,
                     account.CURRENCY_ID,
                     account.PARENT_ACC_ID,
                     account.FINAL_ACC_ID,
                     account.ACC_LEVEL,
                     account.ACC_REMARKS,
                      account.ACC_DEBIT_OR_CREDIT_OR_WITHOUT,
                      account.ACC_TYPE_ID,
                               lang,
                account.ACC_MUST_COST_CENTER);
                }
                else if (account.ACC_TYPE_ID==2)
                {
                    db.MODIFY_FINAL_ACCOUNT(account.ACC_ID, account.ACC_CODE,
                         account.ACC_AR_NAME,
                         account.ACC_EN_NAME,
                         account.ACC_DATE,
                         account.ACC_STATE,
                         account.ACC_CREDIT,
                         account.ACC_DEBIT,
                         account.ACC_MAX_DEBIT,
                         account.CURRENCY_ID,
                         account.PARENT_ACC_ID,
                         account.FINAL_ACC_ID,
                         account.ACC_LEVEL,
                         account.ACC_REMARKS,
                         account.ACC_NSONS,
                         account.ACC_TURNNING_YES_OR_NO,
                         lang);
                }
                else if (account.ACC_TYPE_ID==3)
                {
                    db.MODIFY_COLLECTIVE_ACCOUNT(account.ACC_ID, account.ACC_CODE,
                                                account.ACC_AR_NAME,
                                                account.ACC_EN_NAME,
                                                account.ACC_DATE,
                                                account.ACC_STATE,
                                                account.ACC_CREDIT,
                                                account.ACC_DEBIT,
                                                account.ACC_MAX_DEBIT,
                                                account.CURRENCY_ID,
                                                account.PARENT_ACC_ID,
                                                account.FINAL_ACC_ID,
                                                account.ACC_LEVEL,
                                                account.ACC_REMARKS,
                                                account.ACC_NSONS, 
                                                lang);
                }
                else if (account.ACC_TYPE_ID==4)
                {
                    db.MODIFY_DISTRIBUTIVE_ACCOUNT(account.ACC_ID, account.ACC_CODE,
                             account.ACC_AR_NAME,
                             account.ACC_EN_NAME,
                             account.ACC_DATE,
                             account.ACC_STATE,
                             account.ACC_CREDIT,
                             account.ACC_DEBIT,
                             account.ACC_MAX_DEBIT,
                             account.CURRENCY_ID,
                             account.PARENT_ACC_ID,
                             account.FINAL_ACC_ID,
                             account.ACC_LEVEL,
                             account.ACC_REMARKS,
                             account.ACC_NSONS,
                      
                             lang);
                }
                else if (account.ACC_TYPE_ID==7)
                {
                    db.MODIFY_NORMAL_CUSTOMER_OR_SUPPLIER_ACCOUNT(account.ACC_ID, account.ACC_CODE,
                                 account.ACC_AR_NAME,
                                 account.ACC_EN_NAME,
                                 account.ACC_DATE,
                                 account.ACC_STATE,
                                 account.ACC_MAX_DEBIT,
                                 account.CURRENCY_ID,
                                 account.PARENT_ACC_ID,
                                 account.FINAL_ACC_ID,
                                 account.ACC_LEVEL,
                                 account.ACC_REMARKS,

                                 account.ACC_DEBIT_OR_CREDIT_OR_WITHOUT,
                                 account.ACC_TYPE_ID,

                                 customer.NATIONALITY_ID,
                                 customer.NATION_ID,
                                 customer.GOV_ID,
                                 customer.TOWN_ID,
                                Convert.ToInt32(customer.VILLAGE_ID),
                                 customer.CUST_ADDR_REMARKS,
                                 customer.CUST_EMAIL,
                                 customer.CUST_WEB_SITE,
                                 customer.CUST_PHOTO,
                                 customer.CUST_ZIP_CODE,
                                 customer.CUST_POST_BOX,
                                 customer.SELL_TYPE_ID,
                                 lang
                          );
                }
                else
                {
                    db.MODIFY_NORMAL_ACCOUNT(account.ACC_ID, account.ACC_CODE,
                     account.ACC_AR_NAME,
                     account.ACC_EN_NAME,
                     account.ACC_DATE,
                     account.ACC_STATE,
                     account.ACC_MAX_DEBIT,
                     account.CURRENCY_ID,
                     account.PARENT_ACC_ID,
                     account.FINAL_ACC_ID,
                     account.ACC_LEVEL,
                     account.ACC_REMARKS,
                      account.ACC_DEBIT_OR_CREDIT_OR_WITHOUT,
                      account.ACC_TYPE_ID,
                               lang,
                account.ACC_MUST_COST_CENTER);
                }


                return Ok();
    
            }
            catch (EntityCommandExecutionException ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
                
            }
        
        }
        [HttpGet]
        [Route("GetAccounts")]

        public IHttpActionResult GetAccounts(string lang)
        {
            try
            {
                var accs = db.SELECT_ALL_ACCOUNTS(lang);
                return Ok(accs);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
         
        }
        [HttpGet]
        [Route("GetAccountsCustomer")]
        public IHttpActionResult GetAccountCustomer(string userId,string lang)
        {
            try
            {
                var acc = db.SELECT_ALL_ACCOUNT_CUSTOMER(userId, lang);
                return Ok(acc);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
 
        }
        [HttpGet]
        [Route("GetAccountsSupplier")]
        public IHttpActionResult GetAccountSupplier(string userId,string lang)
        {
            try
            {
                var acc = db.SELECT_ALL_ACCOUNT_SUPPLIER(userId, lang);
                return Ok(acc);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetAccountDetails")]
        public IHttpActionResult GetAccountDetails(string lang)
        {
            try
            {
                var acc = db.SELECT_ALL_ACCOUNTS_DETAILS(lang);
                return Ok(acc);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetCustomerData")]
        public IHttpActionResult GetCustomerData(int accountId)
        {
            try
            {
                var customers = db.SELECT_ALL_Customer(accountId);
                return Ok(customers);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetCustomerBranches")]
        public IHttpActionResult GetCustomerBranches(int accountId)
        {
            try
            {

                var custBrunch= db.CUSTOMER_BRANCHES.Where(a => a.ACC_ID == accountId).ToList();
                if (custBrunch.Count()==0)
                {
                    return Content(HttpStatusCode.NotFound, "لا يوجد بيانات ");
                }
                return Ok(custBrunch);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteAccount")]
        public IHttpActionResult DeleteAccount(int accountId,string lang)
        {
            try
            {
                var acc = db.DELETE_ACCOUNT(accountId, lang);
                return Ok(acc);
            }
            catch (EntityCommandExecutionException ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }

    }
}
