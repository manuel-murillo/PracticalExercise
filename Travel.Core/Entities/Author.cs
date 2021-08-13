using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Column(TypeName = "numeric(10, 0)")]
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(45)]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(45)]
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
