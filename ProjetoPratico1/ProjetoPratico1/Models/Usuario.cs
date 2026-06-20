using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPratico1.Models
{
    [Table("User")]
    public class User
    {
        [Display(Name = "UserID")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "UserName")]
        [Column("Name")]
        public string Nome { get; set; }
    }
}