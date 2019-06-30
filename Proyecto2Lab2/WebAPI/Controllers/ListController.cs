using CoreApi;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:55384,http://localhost:63518", headers: "*", methods: "*")]

    public class ListController : ApiController
    {

        ApiResponse apiResponse = new ApiResponse();

        public IHttpActionResult Get(string Id)
        {

            try
            {
                apiResponse = new ApiResponse();
                var mng = new ListManagemnt();

                var option = new OptionList
                {
                    ID = Id
                };

                var listOptions = mng.RetrieveById(option);
                return Ok(listOptions);

            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }


            return Ok(apiResponse);
        }


    }
}