using Backend_Cocinat3_API.Dtos;
using Backend_Cocinat3_API.Modelos.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Backend_Cocinat3_API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("/api/[controller]/GetUser")]
        public async Task<ActionResult<List<UsuarioModelo>>> VerUsuarios()
        {
        var funcion=new usuarioDto();
        var lista = await funcion.mostrarUsuarios();
        return lista;
        }

       [HttpPost("postUser")]
        public async Task post([FromBody]UsuarioModelo parametros)
        {
            // Lógica para crear un usuario
        var funcion= new usuarioDto();
        await funcion.insertarUsuarios(parametros);
        }

        [HttpPut("putUser")]
        public ActionResult PutUsuario()
        {
            // Lógica para actualizar un usuario
            return Ok();
        }

        //public ActionResult PutUsuario()
        //{

        //    return Ok();
        //}
   
    }
}
