using CoreApi;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;


namespace WebAPI.Controllers
{

    [EnableCors(origins: "http://localhost:55384", headers: "*", methods: "*")]

    public class ContactMethodController : ApiController
    {


        ApiResponse apiResponse = new ApiResponse();


        public IHttpActionResult Get()
        {
            var mng = new ContactMethodManagement();
            apiResponse.Data = mng.RetrieveAll();

            return Ok(apiResponse);
        }

        public IHttpActionResult Get(string id)
        {
            var mng = new ContactMethodManagement();
            var contactMethod = new ContactMethod
            {
                OwnerId = id
            };

            apiResponse.Data = contactMethod;

            return Ok(contactMethod);
        }

        public IHttpActionResult Post (ContactMethod contactMethod)
        {
            var mng = new ContactMethodManagement();
            mng.Create(contactMethod);

            apiResponse.Message = "Action was excecuted!";
            return Ok(apiResponse);
        }

        public IHttpActionResult Put(ContactMethod contactMethod)
        {
            var mng = new ContactMethodManagement();
            mng.Update(contactMethod);

            apiResponse.Message = "Action was excecuted!";
            return Ok(apiResponse);
        }

        public IHttpActionResult Delete(ContactMethod contactMehtod)
        {
            var mng = new ContactMethodManagement();
            mng.Delete(contactMehtod);

            apiResponse.Message = "Action was excecute";
            return Ok(apiResponse);
        }


    }
}
