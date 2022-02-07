using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TheTask
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int QuadrantId { get; set; }
        public Quadrant Quadrant { get; set; }
    }
}
