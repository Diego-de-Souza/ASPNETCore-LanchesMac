using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres.")]
        [Required(ErrorMessage ="Informe o nome da Cateoria.")]
        [Display(Name="nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 100 caracteres.")]
        [Required(ErrorMessage = "Informe a descrição da Cateoria.")]
        [Display(Name = "descrição")]
        public string CategoriaDescricao { get; set; }

        public List<Lanche> Lanches { get; set; }

    }
}
