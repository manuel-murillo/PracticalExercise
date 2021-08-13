using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.Entities
{
    [Table("Editorials")]
    public class Editorial
    {
        [Column(TypeName = "numeric(10, 0)")]
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(45)]
        public string Headquarters { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
