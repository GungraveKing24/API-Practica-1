using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi01.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly EquiposContext _equiposContext;

        public EquiposController(EquiposContext equiposContexto)
        {
            _equiposContext = equiposContexto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get() 
        {
            List<Equipos> listadoEquipo = (from e in _equiposContext.Equipos
                                           select e).ToList();

            if(listadoEquipo.Count == 0)
            {
                return NotFound();
            }
            return Ok(listadoEquipo);
        }

    }
}
