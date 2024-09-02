using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        //inserção dos data annotaions na model para chave primaria
        [Key]
        public int LancheId { get; set; }
        //data annotation do tipo string
        [StringLength(80, MinimumLength =10, ErrorMessage = "O {0} deve ter no minímo {1} e no máximo {2} carateres. ")]
        [Required(ErrorMessage = "Informe o nome do lanche.")]
        [Display(Name = "nome do lanche")]    
        public string Nome { get; set; }
        //data annotation do tipo string
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no minímo {1} e no máximo {2} carateres. ")]
        [Required(ErrorMessage = "Informe a descrição curta do lanche.")]
        [Display(Name = "descrição curta")]
        public string DescricaoCurta { get; set; }
        //data annotation do tipo string
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no minímo {1} e no máximo {2} carateres. ")]
        [Required(ErrorMessage = "Informe a descrição detalhada do lanche.")]
        [Display(Name = "descrição detalhada")]
        public string DescricaoDetalhada { get; set; }
        //data annotation do type decimal
        [Required(ErrorMessage ="Informe o preço do lanche.")]
        [Display(Name="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        //data annotation do tipo string
        [Display(Name ="Caminho Imagem normal")]
        [StringLength(200, ErrorMessage ="A string do nome da imagem deve conter no máximo {1} caracteres.")]
        public string ImagemUrl { get; set; }
        //data annotation do tipo string
        [Display(Name = "Caminho Imagem miniatura")]
        [StringLength(200, ErrorMessage = "A string do nome da imagem deve conter no máximo {1} caracteres.")]
        public string ImagemThumbnailUrl { get; set; }
        //data annotation para type boolean
        [Display(Name="Preferido?")]
        public bool IsLanchePreferido { get; set; }
        //data annottion para o tipo boolean
        [Display(Name ="Em estoque?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
