using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI_CP2.Entities
{
    [Table("clientes")]
    public class ClienteEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("nome")]
        [Required]
        public string Nome { get; set; }

        [Column("CPF")]
        [Required]
        [MinLength(11), MaxLength(14)]
        public string CPF { get; set; }

        [Column("email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Column("telefone")]
        [Required]
        [MinLength(11), MaxLength(12)]
        public string Telefone { get; set; }
    }
}
