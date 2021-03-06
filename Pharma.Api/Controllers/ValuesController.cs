﻿using System.Collections.Generic;
using System.Web.Http;
using AttributeRouting.Web.Mvc;

namespace Pharma.Api.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [GET("api/values")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [GET("api/values/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [POST("api/values")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [PUT("api/values/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [DELETE("api/values/{id}")]
        public void Delete(int id)
        {
        }
    }
}