using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entity_Framework.Models
{
    [Table("tbl_livros")]
    public class Livro
    {
        [Key]
        public long LivroID { get; set; }
        
        [Column("nome_do_livro")]
        [Required]
        [MaxLength(30)]
        public string Titulo { get; set; }
        
        public double Preco { get; set; }

        [NotMapped]
        public string data { get; set; }
    }
}