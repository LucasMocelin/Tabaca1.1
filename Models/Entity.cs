using System;
using System.ComponentModel.DataAnnotations;


namespace Tabaca1._1.Models
{
    public class Entity
    {
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Key]
        public int Id { get; set; }
    }
}
