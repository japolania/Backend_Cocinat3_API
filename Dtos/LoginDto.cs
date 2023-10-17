using System.Security.Principal;

namespace Backend_Cocinat3_API.Dtos
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Pasword { get; set; }
        public string Nombre { get; set; }

    }
}
