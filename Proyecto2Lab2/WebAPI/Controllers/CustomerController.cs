using CoreApi;
using DataAccessEF.Services;
using Entities_POJO;
using Exceptions;
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

            // ** DAO
            //var mng = new CustomerManagement();
            //apiResp.Data = mng.RetrieveAll();


            //** EF
            var ef = new CustomerService();
            apiResp.Data = ef.retrieveAll();

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

        public IHttpActionResult Post(Customer customer)
        {

            try {
                //DAO
                var mng = new CustomerManagement();
                mng.Create(customer);


                //** EF
                //var ef = new CustomerService();
                //ef.Create(customer);



                apiResp = new ApiResponse();
                apiResp.Message = "Action was excecuted...";

                return Ok(apiResp);


            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-"
                    + bex.AppMessage.Message));
            }

        }

        public IHttpActionResult Put (Customer customer)
        {
            //DAO
            //var mng = new CustomerManagement();
            //mng.Update(customer);


            //** EF
            var ef = new CustomerService();
            ef.Update(customer);
            apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted";

            return Ok(apiResp);
        }

        public IHttpActionResult Delete (Customer customer)
        {
            //
            //var mng = new CustomerManagement();
            //mng.Delete(customer);

            //** EF
            var ef = new CustomerService();
            ef.Delete(customer);

            apiResp = new ApiResponse();
            apiResp.Message = "Action was excecuted";

            return Ok(apiResp);
        }

        



    }
}
