using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI_CP2.Entities
{
    [Table("produtos")]
    public class ProdutoEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("produto")]
        [Required]
        public string Produto { get; set; }

        [Column("Categoria")]
        [Required]
        public string Categoria { get; set; }

        [Column("preco")]
        [Required]
        public decimal Preco { get; set; }

        [Column("qtd_estoque")]
        [Required]
        public int QtdEstoque { get; set; }
    }
}
