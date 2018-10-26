using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class EducationLevel
    {
        public int ElId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Education Level cannot be longer than 100 characters.")]
        [Column("EL_Name")]
        [Display(Name = "Education Level")]
        public string ElName { get; set; }
    }
}
