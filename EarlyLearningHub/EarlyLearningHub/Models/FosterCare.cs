using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class FosterCare
    {
        public int FcId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Foster Care Option cannot be longer than 50 characters.")]
        [Column("FC_Option")]
        [Display(Name = "Foster Care Option")]
        public string FcOptions { get; set; }
    }
}
