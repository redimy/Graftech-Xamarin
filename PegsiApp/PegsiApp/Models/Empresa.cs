using System;
using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Empresa
    {
        public Empresa()
        {
            EmpresaDocumentos1 = new HashSet<EmpresaDocumentos1>();
            Participante = new HashSet<Participante>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Rfc { get; set; }
        public string NombreFactura { get; set; }
        public string DireccionFactura { get; set; }
        public int? NumeroProveedor { get; set; }
        public string NombreResponsable { get; set; }
        public string ApPatResponsable { get; set; }
        public string ApMatResponsable { get; set; }
        public string PuestoResponsable { get; set; }
        public string TelOficinaResponsable { get; set; }
        public string TelCelularResponsable { get; set; }
        public string CorreoResponsable { get; set; }
        public string CorreoResponsable2 { get; set; }
        public string TelefonoFactura { get; set; }
        public string CorreoFactura { get; set; }
        public bool Activa { get; set; }
        public string UsuarioCanvas { get; set; }
        public string ContrasenaCanvas { get; set; }
        public string Observaciones { get; set; }
        public string Domicilio { get; set; }
        public string RazonSocial { get; set; }
        public string DocSat { get; set; }
        public string DocCedula { get; set; }
        public string DocPagoImss { get; set; }
        public DateTime? VigenciaPagoImss { get; set; }
        public string DocIdentificacion { get; set; }
        public int? EmpresaMaestra { get; set; }
        public int? RepresentanteLegal { get; set; }
        public string Calle { get; set; }
        public string NoExt { get; set; }
        public string NoInt { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string CalleFac { get; set; }
        public string NoExtFac { get; set; }
        public string NoIntFac { get; set; }
        public string ColoniaFac { get; set; }
        public string CiudadFac { get; set; }
        public string EstadoFac { get; set; }
        public string PaisFac { get; set; }
        public string CodigoPostalFac { get; set; }

        public int empresaMasterId { get; set; }

        public virtual ICollection<EmpresaDocumentos1> EmpresaDocumentos1 { get; set; }
        public virtual ICollection<Participante> Participante { get; set; }
    }
}
