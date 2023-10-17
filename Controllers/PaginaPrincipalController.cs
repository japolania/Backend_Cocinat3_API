using Microsoft.AspNetCore.Mvc;

namespace Backend_Cocinat3_API.Controllers
{
    [ApiController]
    public class PaginaPrincipalController : ControllerBase
    {
        [HttpGet]
        [Route("/api/[controller]/GetPublicacion")]
        public ActionResult GetPubllicacion()
        {

            return Ok();
        }
    }
}
