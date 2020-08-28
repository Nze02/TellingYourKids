using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TellingYourKids.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PostId")]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "Story is required.")]
        public string Story { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public string Status { get; set; } = "Not Approved";
    }
}
