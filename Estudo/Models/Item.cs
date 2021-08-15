using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudo.Models
{
    [Table("ITEM")]
    public class Item
    {
        [Display(Name = "Id")]
        [Column("ID")]
        public int ID { get; set; }

        [Display(Name = "Nome")]
        [Column("NAME")]
        public string Name { get; set; }

        [Display(Name = "Preço")]
        [Column("PRICE")]
        public decimal Price { get; set; }

        [Display(Name = "Criado Em")]
        [Column("CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Atualizado Em")]
        [Column("UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "Deletado Em")]
        [Column("DeletedAt")]
        public DateTime? DeletedAt { get; set; }
    }
}