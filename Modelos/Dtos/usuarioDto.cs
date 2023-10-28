using Backend_Cocinat3_API.conexion;
using Backend_Cocinat3_API.Dtos;
using System.Data;
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
    public async Task insertarUsuarios(UsuarioModelo parametros)
        {
        using(var sql = new SqlConnection(cn.cadenaSQL()))
            {
            using (var cmd = new SqlCommand("insertarUsuarios", sql))
                {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", parametros.nombre);
                cmd.Parameters.AddWithValue("@apellido", parametros.apellido);
                cmd.Parameters.AddWithValue("@telefono", parametros.telefono);
                cmd.Parameters.AddWithValue("@email", parametros.email);
                cmd.Parameters.AddWithValue("@contrasema", parametros.contrasena);
                cmd.Parameters.AddWithValue("@nacionalidad", parametros.nacionalidad);

                await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
