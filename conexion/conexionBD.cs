using System.Security.AccessControl;

namespace Backend_Cocinat3_API.conexion
{
    public class conexionBD
    {
        private string conectionstring = string.Empty;
        public conexionBD() 
        { 
            var constructo= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            conectionstring = constructo.GetSection("ConnectionStrings:conexion").Value;
        }
        public string cadenaSQL()
        {
            return conectionstring;
        }
    }
}
