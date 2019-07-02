﻿using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    public class EmailController : ApiController
    {
        // GET: api/Email
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Email
        public IHttpActionResult Post(Email email)
        {
          
            var service = new EmailService(email);
            ApiResponse apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted...";

            return Ok(apiResp);

        }

        // PUT: api/Email/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Email/5
        public void Delete(int id)
        {
        }
    }
}
