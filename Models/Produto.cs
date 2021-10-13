using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tabaca1._1.Models
{
    [Table(nameof(Produto))]
    public class Produto : Entity
    {
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(100)]
        public String Nome { get; set; }

        [Column(TypeName ="money")]
        public decimal Preco { get; set; }

        [Column("Quantidade")]
        public int Qtde { get; set; }

        [Column(TypeName = "money")]
        public decimal PrecoCust { get; set; }
        public int MarcaDeProdutoId { get; set; }
        public int TipoDeProdutoId { get; set; }
       
        [ForeignKey(nameof(TipoDeProdutoId))]
        public virtual TipoDeProduto TipoDeProduto { get; set; }
               
        [ForeignKey(nameof(MarcaDeProdutoId))]
        public virtual MarcaDeProduto MarcaDeProduto { get; set; }
        
    }
}
