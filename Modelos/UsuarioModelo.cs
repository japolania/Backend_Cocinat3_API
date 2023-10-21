namespace Backend_Cocinat3_API.Dtos
{
    public class UsuarioModelo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public int rolId { get; set; }
        public string nacionalidad { get; set; }

    }
}
