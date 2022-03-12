using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.DAL;

namespace WebApi.Controllers
{
    public class SignInController : ApiController
    {
        private Smart1Entities4 db;
        public SignInController()
        {
            db = new Smart1Entities4();
        }

        //public IHttpActionResult LogIn()
        //{
        //    db.
        //}
    }
}
