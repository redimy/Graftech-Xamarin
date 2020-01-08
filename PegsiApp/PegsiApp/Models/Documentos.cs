using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Documentos
    {
        public Documentos()
        {
            ParticipanteDocumentos = new HashSet<ParticipanteDocumentos>();
        }

        public int Id { get; set; }
        public string NombreDocumento { get; set; }
        public int? Activo { get; set; }

        public virtual ICollection<ParticipanteDocumentos> ParticipanteDocumentos { get; set; }
    }
}
