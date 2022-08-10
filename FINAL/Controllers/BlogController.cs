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
    public class BlogController : ApiController
    {
        [Route("api/blogs")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = BlogServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/blog/create")]
        [HttpPost]
        public HttpResponseMessage Create(BlogModel st)
        {
            var data = BlogServices.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }
        [Route("api/blog/Get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {

            
            var data = BlogServices.GetBlog(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/blog/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = BlogServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
        [Route("api/blog/update/{id}")]
        [HttpPost]
        public HttpResponseMessage update(BlogModel st)
        {
            var data = BlogServices.Update(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }


    }
}
