using System;

namespace PegsiApp.Models
{
    public class ParticipanteCertif
    {
        public int Id { get; set; }
        public int ParticipanteId { get; set; }
        public DateTime? FechaExamen { get; set; }
        public string SalaExamen { get; set; }
        public string CertificacionObtenida { get; set; }
        public int? Calificacion { get; set; }
        public DateTime? FechaValidez { get; set; }

        public virtual Participante Participante { get; set; }
    }
}
