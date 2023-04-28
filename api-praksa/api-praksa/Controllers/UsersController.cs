using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace api_praksa.Controllers
{
    [Route("api/")]
    public class UsersController : Controller
    {
        // GET: api/values
        [HttpGet("/admin/listofusers")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Post 1", "Post 2" };
        }

        // GET api/values/5
        [HttpGet("/admin/listofuser/{id}")]
        public string Get(int id)
        {
            return "Post by ID-1";
        }



        // POST api/values
        [HttpPost("/register")]
        public void Register([FromBody] string value)
        {

        }

        // GET api/values/5
        [HttpGet("/login")]
        public string Login(int id)
        {
            return "Post by ID-1";
        }


        // DELETE api/values/5
        [HttpDelete("/admin/listofusers/{id}")]
        public void Delete(int id)
        {
        }
    }
}

