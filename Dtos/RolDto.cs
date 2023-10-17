namespace Backend_Cocinat3_API.Dtos
{
    public class RolDto
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public List<UsuarioDto> Usuario { get; set; }

    }
}
