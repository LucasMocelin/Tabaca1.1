using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tabaca1._1.Models
{
    [Table(nameof(MarcaDeProduto))]

    public class MarcaDeProduto : Entity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}