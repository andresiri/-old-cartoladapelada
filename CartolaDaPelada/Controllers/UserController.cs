using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CartolaDaPelada.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;        

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost]        
        public JsonResult Post([FromBody]User obj)
        {
            try
            {
                var user = HttpContext.User;     
                var newUser = _userService.Create(obj);

                return Json(newUser);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }        
    }
}
