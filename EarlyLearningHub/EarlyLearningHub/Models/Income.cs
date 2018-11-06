using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class Income
    {
        public Income()
        {
            StudentLevel = new HashSet<StudentLevel>();
        }

        public int IncId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Income cannot be longer than 50 characters.")]
        [Column("INC_Range")]
        [Display(Name = "Income")]
        public string IncRange { get; set; }

        public ICollection<StudentLevel> StudentLevel { get; set; }
    }
}
