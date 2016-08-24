using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Services;

namespace CartolaDaPelada.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IUserService _userService;

        public ValuesController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/values
        [HttpGet]
        public User Get()
        {
            var xico = new User();
            xico.FirstName = "Andre";
            xico.LastName = "Miranda";
            xico.Email = "andremirannda@gmail.com";
            xico.Password = "andresiri";

            xico = _userService.Create(xico);

            return xico;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
