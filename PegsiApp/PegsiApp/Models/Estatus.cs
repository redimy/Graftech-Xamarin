using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Estatus
    {
        public Estatus()
        {
            ParticipanteCurso = new HashSet<ParticipanteCurso>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ParticipanteCurso> ParticipanteCurso { get; set; }
    }
}
