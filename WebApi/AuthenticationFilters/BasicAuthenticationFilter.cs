using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebApi.DAL;
using WebApi.Security;
using WebApi.Singletons;

namespace WebApi.AuthenticationFilters
{
    public class BasicAuthenticationFilter : AuthorizationFilterAttribute
    {
        
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                string hash = "f0xle@rn";
                string actionName = actionContext.ActionDescriptor.ActionName;
                string authantoken = actionContext.Request.Headers.Authorization.Parameter;

                byte[] data = Convert.FromBase64String(authantoken);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = triple.CreateDecryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        string decodedToken = UTF8Encoding.UTF8.GetString(result);
                        string[] uidpasfrm = decodedToken.Split(':');
                        string uid = uidpasfrm[0];
                        string password = uidpasfrm[1];
                        string formName = uidpasfrm[2];

                        //var oprev = db.UsrPrevilegs.SingleOrDefault(a => a.Token == authantoken && a.FormName == formName);
                        using(Smart1Entities4 db =new Smart1Entities4())
                        {
                            var oprev = db.TokenUsers.Where(a => a.Token == authantoken && a.FormName == formName).SingleOrDefault();
                            if (actionName.Contains("Get"))
                            {
                                if (UserSecurity.Login(uid, password, formName) && oprev.OpPreview == true)
                                {
                                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                                }
                                else
                                {
                                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                                }
                            }
                            else if (actionName.Contains("Add") || actionName.Contains("Post"))
                            {
                                if (UserSecurity.Login(uid, password, formName) && oprev.OpAdd == true)
                                {
                                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                                }
                                else
                                {
                                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                                }
                            }
                            else if (actionName.Contains("Update"))
                            {
                                if (UserSecurity.Login(uid, password, formName) && oprev.OpUpdate == true)
                                {
                                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                                }
                                else
                                {
                                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                                }
                            }
                            else if (actionName.Contains("Delete"))
                            {
                                if (UserSecurity.Login(uid, password, formName) && oprev.OpDelete == true)
                                {
                                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                                }
                                else
                                {
                                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                                }
                            }
                            else if (actionName.Contains("Search"))
                            {
                                if (UserSecurity.Login(uid, password, formName) && oprev.OpSearch == true)
                                {
                                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                                }
                                else
                                {
                                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                                }
                            }
                            else if (actionName.Contains("RPT"))
                            {
                                if (UserSecurity.Login(uid, password, formName) && oprev.OpPrint == true)
                                {
                                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                                }
                                else
                                {
                                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                                }
                            }
                        }
                       

                    }
                }

            
              



            }


        }
    }
}