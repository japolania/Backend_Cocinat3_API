using Backend_Cocinat3_API.conexion;
using Backend_Cocinat3_API.Dtos;
using System.Data.SqlClient;

namespace Backend_Cocinat3_API.Modelos.Dtos
{
    public class usuarioDto
    {
    conexionBD cn=new conexionBD();
    public async Task<List<UsuarioModelo>> mostrarUsuarios()
        {
        var lista =new List<UsuarioModelo>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
            using(var cmd =new SqlCommand("mostrarUsuarios", sql))
                {
                await sql.OpenAsync();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using(var item = await cmd.ExecuteReaderAsync())
                    {
                    while (await item.ReadAsync())
                        {
                        var UsuarioModelo = new UsuarioModelo();
                            UsuarioModelo.id = (int)item["id"];
                            UsuarioModelo.nombre = (string)item["nombre"];
                            UsuarioModelo.apellido = (string)item["apellido"];
                            UsuarioModelo.telefono = (string)item["telefono"];
                            UsuarioModelo.email = (string)item["email"];
                            lista.Add(UsuarioModelo);
                        }
                    }
                return lista;
                }
            }
        }
    }
}
