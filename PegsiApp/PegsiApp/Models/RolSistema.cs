using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class RolSistema
    {
        public RolSistema()
        {
            UsuarioRol = new HashSet<UsuarioRol>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<UsuarioRol> UsuarioRol { get; set; }
    }
}
