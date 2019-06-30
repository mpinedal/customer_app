using CoreApi;
using DataAccessEF.Services;
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

    [EnableCors(origins: "http://localhost:55384,http://localhost:63518", headers: "*", methods: "*")]

    public class ContactMethodController : ApiController
    {


        ApiResponse apiResponse = new ApiResponse();


        public IHttpActionResult Get()
        {
            //dao
            //var mng = new ContactMethodManagement();
            //apiResponse.Data = mng.RetrieveAll();

            //ef
            var ef = new ContactMethodService();
            apiResponse.Data = ef.retrieveAll();

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
            //var mng = new ContactMethodManagement();
            //mng.Create(contactMethod);


            //EF
            var ef = new ContactMethodService();
            ef.Create(contactMethod);

            apiResponse.Message = "Action was excecuted!";
            return Ok(apiResponse);
        }

        public IHttpActionResult Put(ContactMethod contactMethod)
        {
            //dao
            var mng = new ContactMethodManagement();
            mng.Update(contactMethod);

            //EF
            //var ef = new ContactMethodService();
            //ef.Update(contactMethod);

            apiResponse.Message = "Action was excecuted!";
            return Ok(apiResponse);
        }

        public IHttpActionResult Delete(ContactMethod contactMethod)
        {
            //Dao
            var mng = new ContactMethodManagement();
            mng.Delete(contactMethod);

            //EF
            //var ef = new ContactMethodService();
            //ef.Delete(contactMethod);

            apiResponse.Message = "Action was excecuted...";
            return Ok(apiResponse);
        }


    }
}
