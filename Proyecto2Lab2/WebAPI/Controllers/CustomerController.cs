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

    [EnableCors(origins: "http://localhost:55384,http://localhost:63518", headers: "*", methods: "*")]

   
    public class CustomerController : ApiController
    {
        ApiResponse apiResp = new ApiResponse();

        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new CustomerManagement();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        public IHttpActionResult Get(string id)
        {
           
                var mng = new CustomerManagement();
                var customer = new Customer
                {
                    Id = id
                };
                customer = mng.RetrieveById(customer);
                apiResp.Data = customer;
                return Ok(apiResp);
        }

        public IHttpActionResult Post (Customer customer)
        {
            var mng = new CustomerManagement();
            mng.Create(customer);

            apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted...";

            return Ok(apiResp);


        }

        public IHttpActionResult Put (Customer customer)
        {
            var mng = new CustomerManagement();
            mng.Update(customer);

            apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted";

            return Ok(apiResp);
        }

        public IHttpActionResult Delete (Customer customer)
        {
            var mng = new CustomerManagement();
            mng.Delete(customer);

            apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted";

            return Ok(apiResp);
        }

        



    }
}
