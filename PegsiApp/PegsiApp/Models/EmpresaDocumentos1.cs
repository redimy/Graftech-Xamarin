using System;

namespace PegsiApp.Models
{
    public class EmpresaDocumentos1
    {
        public int Id { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public string Documento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int? Activo { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}
