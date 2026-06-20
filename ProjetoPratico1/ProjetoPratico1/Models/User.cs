using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPratico1.Models
{
    [Table("Users")]
    public class User
    {
        [Display(Name = "UserID")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }

    }
}
