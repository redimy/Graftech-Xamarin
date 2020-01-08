using System;

namespace PegsiApp.Models
{
    public class ParticipanteDocumentos
    {
        public int Id { get; set; }
        public int? IdParticipante { get; set; }
        public int? IdDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public string Documento { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public virtual Documentos IdDocumentoNavigation { get; set; }
        public virtual Participante IdParticipanteNavigation { get; set; }
    }
}
