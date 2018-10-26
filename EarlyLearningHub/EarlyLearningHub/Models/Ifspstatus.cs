using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.Options;

namespace EarlyLearningHub.Models
{
    public partial class Ifspstatus
    {
        public int IsId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "IFSP Option cannot be longer than 50 characters.")]
        [Column("IS_Options")]
        [Display(Name = "IFSP Option")]
        public string IsOptions { get; set; }
    }
}
