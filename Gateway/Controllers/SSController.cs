﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gateway.Controllers
{
    public class SController : ApiController
    {
        // GET: api/SS
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SS/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SS
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SS/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SS/5
        public void Delete(int id)
        {
        }
    }
}
