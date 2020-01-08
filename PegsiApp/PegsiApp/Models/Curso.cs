using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Curso
    {
        public Curso()
        {
            CursoCategoria = new HashSet<CursoCategoria>();
            ParticipanteCurso = new HashSet<ParticipanteCurso>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public virtual ICollection<CursoCategoria> CursoCategoria { get; set; }
        public virtual ICollection<ParticipanteCurso> ParticipanteCurso { get; set; }
    }
}
