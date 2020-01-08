namespace PegsiApp.Models
{
    public class ParticipanteCurso
    {
        public int ParticipanteId { get; set; }
        public int CursoId { get; set; }
        public int EstatusId { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Participante Participante { get; set; }
    }
}
