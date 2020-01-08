using System;

namespace PegsiApp.Models
{
    public class CursosExternos
    {
        public int Id { get; set; }
        public int ParticipanteId { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Documento { get; set; }
        public string Dc3 { get; set; }

        public virtual Participante Participante { get; set; }
    }
}
