using PegsiApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraftechApp.Dtos
{
    public class ParticipanteDto
    {
        public ParticipanteDto()
        {
            ParticipanteDocumentos = new HashSet<ParticipanteDocumentos>();
        }

        public int Id { get; set; }
        public int? EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CorreoElectronico { get; set; }
        public string Foto { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Estatus { get; set; }

        public List<String> documentosVencidos { get; set; }
        public string razonSocial { get; set; }
        public int EmpresaMasterId { get; set; }
        public ICollection<CursosExternosDto> CursosExternos { get; set; }

        public virtual ICollection<ParticipanteDocumentos> ParticipanteDocumentos { get; set; }
    }
}
