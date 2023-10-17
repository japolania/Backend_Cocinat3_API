using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Backend_Cocinat3_API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
       };
        [HttpGet]
        [Route("/api/[controller]/GetUser")]
        public async Task<ActionResult<List<UsuarioModelo>>> VerUsuario(int id)
        {
            return Ok();
        }
        
        [HttpPost]
        [Route("/api/[controller]/postUser")]
       
        [HttpPut]
        [Route("/api/[controller]/PutUser")]

        public ActionResult PutUsuario()
        {

            return Ok();
        }

    }
}
