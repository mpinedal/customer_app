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

    public class DirectionController : ApiController
    {

        ApiResponse apiResponse = new ApiResponse();

        public IHttpActionResult Get()
        {
            apiResponse = new ApiResponse();
            //var mng = new DirectionManagement();
            //apiResponse.Data = mng.RetrieveAll();

            //** EF
            var ef = new DirectionService();
            apiResponse.Data = ef.retrieveAll();


            return Ok(apiResponse);
        }

        public IHttpActionResult Get(string id)
        {
            var mng = new DirectionManagement();

            var direction = new Direction
            {
                OwnerId = id
            };

            direction = mng.RetrieveById(direction);
            apiResponse.Data = direction;

            return Ok(apiResponse);

        }

        public IHttpActionResult Post (Direction direction)
        {
            var mng = new DirectionManagement();
            mng.Create(direction);

            apiResponse.Message = "Action excecuted....";
            return Ok(apiResponse);
        }

        public IHttpActionResult Put (Direction direction)
        {
            var mng = new DirectionManagement();
            mng.Update(direction);

            apiResponse.Message = "Action excecuted....";
            return Ok(apiResponse);
        }

        public IHttpActionResult Delete (Direction direction)
        {
            var mng = new DirectionManagement();
            mng.Delete(direction);

            apiResponse.Message = "Action excecuted...";
            return Ok(apiResponse);
        }


    }
}


  