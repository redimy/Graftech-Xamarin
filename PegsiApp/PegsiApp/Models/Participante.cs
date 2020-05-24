using System;
using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Participante
    {
        public Participante()
        {
            CursosExternos = new HashSet<CursosExternos>();
            ParticipanteCertif = new HashSet<ParticipanteCertif>();
            ParticipanteCurso = new HashSet<ParticipanteCurso>();
            ParticipanteDocumentos = new HashSet<ParticipanteDocumentos>();
        }

        public int Id { get; set; }
        public int? EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Certificaciones { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Foto { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Imss { get; set; }
        public string CartaNoAntecedentes { get; set; }
        public string RegistroImss { get; set; }
        public string UsuarioCanvas { get; set; }
        public string PasswordCanvas { get; set; }
        public string Matricula { get; set; }
        public bool? Credencial { get; set; }
        public string MotivoVeto { get; set; }
        public string PagoSua { get; set; }
        public string PagoSuaArchivo { get; set; }
        public bool? Activo { get; set; }
        public string ContactoOpcional { get; set; }
        public string ContactoTelefono { get; set; }
        public string Estatus { get; set; }
        public string CurpFile { get; set; }
        public string Departamento { get; set; }
        public string Grupo { get; set; }
        public List<String> documentosVencidos { get; set; }
        public string razonSocial { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<CursosExternos> CursosExternos { get; set; }
        public virtual ICollection<ParticipanteCertif> ParticipanteCertif { get; set; }
        public virtual ICollection<ParticipanteCurso> ParticipanteCurso { get; set; }
        public virtual ICollection<ParticipanteDocumentos> ParticipanteDocumentos { get; set; }
    }
}
