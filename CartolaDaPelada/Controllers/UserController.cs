using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CartolaDaPelada.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;        

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]User obj)
        {
            try
            {
                var newUser = new User();
                newUser.Email = "andremirannda@gmail.com";
                newUser.FirstName = "Andre";
                newUser.LastName = "Miranda";
                newUser.Position = "Atacante";

                newUser = _userService.Create(newUser);

                return Json(newUser);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }        
    }
}
