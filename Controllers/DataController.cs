using DataTableWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DataTableWebAPI.Controllers
{

    [RoutePrefix("api/Data")]
    public class DataController : ApiController
    {
        [HttpGet]
        [Route("GetData")]
        public IHttpActionResult GetData()
        {
            try
            {
                var data = new List<DataItem>
                {
                    new DataItem { Id = 1, Name = "Item 1", Value = 10 },
                    new DataItem { Id = 2, Name = "Item 2", Value = 20 },
                    new DataItem { Id = 3, Name = "Item 3", Value = 30 },
                    new DataItem { Id = 4, Name = "Item 4", Value = 40 },
                    new DataItem { Id = 5, Name = "Item 5", Value = 50 },
                    new DataItem { Id = 6, Name = "Item 6", Value = 60 },
                };

                return Ok(data);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}