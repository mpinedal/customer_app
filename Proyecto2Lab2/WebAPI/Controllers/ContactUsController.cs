using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controllers
{

    [EnableCors(origins: "http://localhost:55384,http://localhost:63518", headers: "*", methods: "*")]


    public class ContactUsController : ApiController
    {
        // GET: api/ContactUs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ContactUs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ContactUs
        // POST: api/Email
        public IHttpActionResult Post(Email email)
        {
            string data = "content";
            var service = new EmailService(email);
            ApiResponse apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted...";

            return Ok(apiResp);

        }

        // PUT: api/ContactUs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ContactUs/5
        public void Delete(int id)
        {
        }
    }
}
