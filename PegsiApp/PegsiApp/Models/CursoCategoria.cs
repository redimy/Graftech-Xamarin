namespace PegsiApp.Models
{
    public class CursoCategoria
    {
        public int CursoId { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
