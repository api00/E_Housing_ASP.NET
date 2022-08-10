using BLL.Bos.BuyerBos;
using BLL.Services.Buyer_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FINAL.Controllers.Buyer_controller
{
    public class ComplainController : ApiController
    {
        [Route("api/complains")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ComplainService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/complains/create")]
        [HttpPost]
        public HttpResponseMessage Create(ComplainModel st)
        {
            var data = ComplainService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }
        [Route("api/complains/Get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {


            var data = ComplainService.GetUser(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/complains/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = ComplainService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
        [Route("api/complains/update/{id}")]
        [HttpPost]
        public HttpResponseMessage update(ComplainModel st)
        {
            var data = ComplainService.Update(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }

    }
}
