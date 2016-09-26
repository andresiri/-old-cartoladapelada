using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CartolaDaPelada.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PeladaController : BaseController
    {
        private readonly IPeladaService _peladaService;

        public PeladaController(IPeladaService peladaService)
        {
            _peladaService = peladaService;
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            try
            {
                var pelada = _peladaService.Read(id);
                return Json(pelada);
            }
            catch (Exception ex)
            {

                return Json(ex);
            }
        }

        [HttpPost]
        public JsonResult Post([FromBody]Pelada obj)
        {
            try
            {
                var pelada = _peladaService.Create(obj);

                return Json(pelada);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
        
        [HttpDelete("{id}")]
        public JsonResult Delete([FromRoute]int id)
        {
            try
            { 
                _peladaService.Delete(id);

                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}
