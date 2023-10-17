using Backend_Cocinat3_API.Dtos;

namespace Backend_Cocinat3_API.Repositories
{
    public interface IUsuarioRepositiries
    {
        Task<UsuarioDto> CrearUsuario(UsuarioDto usuario);
        Task<UsuarioDto> ActualizarUsuario(UsuarioDto usuario);
        Task<bool> EliminarUsuario(int id);
        Task<List<UsuarioDto>> MostrarUsuario();
        Task<UsuarioDto> VerUsuario(int id);
        Task<int> login(string correo, string clave);
    }
}
