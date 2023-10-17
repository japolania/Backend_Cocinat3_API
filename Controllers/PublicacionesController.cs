using Microsoft.AspNetCore.Mvc;

namespace Backend_Cocinat3_API.Controllers
{
    [ApiController]
    
    public class PublicacionesController : ControllerBase
    {
        [HttpGet]
        [Route("/api/[controller]/Publicaciones")]
        public ActionResult Get()
        {

            return Ok();
        }
    }
}
