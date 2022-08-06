using BLL.Bos;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FINAL.Controllers
{
    public class UserDetailController : ApiController
    {
        [Route("api/user")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/user/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserDetailModel st)
        {
            var data = UserServices.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }
        [Route("api/user/Get/{id}")]
        [HttpPost]
        public HttpResponseMessage Get(int id)
        {
           
            var data = UserServices.GetUser(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/  ")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {

            var data = UserServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }

    }
}
