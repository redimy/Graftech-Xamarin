using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Usuarios
    {
        public Usuarios()
        {
            UsuarioRol = new HashSet<UsuarioRol>();
        }

        public int Id { get; set; }
        public string Cuenta { get; set; }
        public string Salt { get; set; }
        public string Contrasena { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPrimario { get; set; }
        public string ApellidoSecundario { get; set; }
        public string CorreoElectronico { get; set; }

        public virtual ICollection<UsuarioRol> UsuarioRol { get; set; }
    }
}
