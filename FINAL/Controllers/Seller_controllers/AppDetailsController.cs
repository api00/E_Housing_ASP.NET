using BLL.Bos.SellerBos;
using BLL.Services.Seller_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FINAL.Controllers.Seller_controllers
{
    public class AppDetailsController : ApiController
    {

        [Route("api/Appartments")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = App_Services.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Appartment/create")]
        [HttpPost]
        public HttpResponseMessage Create(App_DetilModel st)
        {
            var data = App_Services.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }
        [Route("api/Appartment/Get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {


            var data = App_Services.GetBlog(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Appartment/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = App_Services.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
    }
}
