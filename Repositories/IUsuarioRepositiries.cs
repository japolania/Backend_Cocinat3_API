using Backend_Cocinat3_API.Dtos;

namespace Backend_Cocinat3_API.Repositories
{
    public interface IUsuarioRepositiries
    {
        Task<UsuarioModelo> CrearUsuario(UsuarioModelo usuario);
        Task<UsuarioModelo> ActualizarUsuario(UsuarioModelo usuario);
        Task<bool> EliminarUsuario(int id);
        Task<List<UsuarioModelo>> MostrarUsuario();
        Task<UsuarioModelo> VerUsuario(int id);
        Task<int> login(string correo, string clave);
    }
}
