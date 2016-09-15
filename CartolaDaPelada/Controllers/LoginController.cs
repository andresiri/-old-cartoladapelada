using Microsoft.AspNetCore.Mvc;
using System;
using Domain.Services;
using Domain.Entities.Models;

namespace CartolaDaPelada.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
                
        [HttpPost]
        public JsonResult Post([FromBody]LoginModel input)
        {
            try
            {
                var result = _loginService.Login(input.Email, input.Password);

                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }        
    }
}
