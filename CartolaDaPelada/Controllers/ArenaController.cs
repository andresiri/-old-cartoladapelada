using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using System;
using Domain.Services;

namespace CartolaDaPelada.Controllers
{
    [Route("api/[controller]")]
    public class ArenaController : BaseController
    {
        private readonly IArenaService _arenaService;

        public ArenaController(IArenaService arenaService)
        {
            _arenaService = arenaService;
        }
            
        [HttpPost]
        public JsonResult Post([FromBody]Arena arena)
        {
            try
            {
                var newArena = _arenaService.Create(arena);

                return Json(newArena);
            }
            catch (Exception ex)
            {

                return Json(ex);
            }
        }       
    }
}
