using System.Collections.Generic;

namespace PegsiApp.Models
{
    public class Categoria
    {
        public Categoria()
        {
            CursoCategoria = new HashSet<CursoCategoria>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<CursoCategoria> CursoCategoria { get; set; }
    }
}
