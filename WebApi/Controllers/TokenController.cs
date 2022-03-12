using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using WebApi.DAL;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class TokenController : ApiController
    {
        private Smart1Entities4 db;
        public TokenController()
        {
            db = new Smart1Entities4();
        }
        [Route("get/token"), HttpPost]
        public string GetToken( UIDViewModel viewModel)
        {
            
            string hash = "f0xle@rn";
         
                byte[] data = UTF8Encoding.UTF8.GetBytes(viewModel.UID1 + ":" + viewModel.UPWD + ":" +viewModel.FormName);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = triple.CreateEncryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        var token = Convert.ToBase64String(result, 0, result.Length);
                        var ui = db.UIDs.Where(z => z.UID1 == viewModel.UID1 && z.UPWD == viewModel.UPWD).SingleOrDefault();
                        var uidtoken = db.UsrPrevilegs.Where(z => z.FormName==viewModel.FormName&&z.UID==viewModel.UID1).FirstOrDefault();

                    if (ui != null)
                        {
                            ui.ExpireDate = DateTime.Now.AddDays(1);
                            ui.TOKEN = token;
                            uidtoken.Token = token;
                            db.SaveChanges();

                        }
                    if (ui.ExpireDate<DateTime.Now)
                    {
                        return "your software expired";
                    }
                       
                        return token;
                    }
                }
        }
        //[Route("get/tokeen"), HttpGet, HttpPost]
        //public string GetTokeen(UID uid)
        //{
        //    var isUserExist = db.UIDs.Any(a => a.UID1 == uid.UID1 && a.UPWD == uid.UPWD);
        //    if (isUserExist)
        //    {
        //        Guid guid = Guid.NewGuid();
        //        return guid.ToString();
        //    }
        //    else
        //    {
        //        return "User Not Exist";
        //    }
        //}
    }
}
