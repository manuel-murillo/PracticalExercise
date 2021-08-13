using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.Entities
{
    [Table("Books")]
    public class Book
    {
        [Column(TypeName = "numeric(13, 0)")]
        [Key]
        public long Isbn { get; set; }

        [ForeignKey("Editorial")]
        public long EditorialId { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(45)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Synopsis { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(45)]
        public string Pages { get; set; }

        public virtual Editorial Editorial { get; set; }

        public virtual ICollection<Author> Authors { get; set; } = new HashSet<Author>();
    }
}
