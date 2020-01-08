namespace PegsiApp.Models
{
    public class UsuarioRol
    {
        public int UsuarioId { get; set; }
        public int RolId { get; set; }

        public virtual RolSistema Rol { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}
