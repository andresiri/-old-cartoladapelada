using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;

namespace CartolaDaPelada.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PeladaUserController : BaseController
    {
        private readonly IPeladaUserService _peladaUserService;

        public PeladaUserController(IPeladaUserService peladaUserService)
        {
            _peladaUserService = peladaUserService;
        }

        [HttpPost]
        public JsonResult Post([FromBody]PeladaUser obj)
        {
            try
            {
                var peladaUser = _peladaUserService.Create(obj);

                return Json(peladaUser);
            }
            catch (System.Exception ex)
            {
                return Json(ex);
            }
        }        
    }
}
