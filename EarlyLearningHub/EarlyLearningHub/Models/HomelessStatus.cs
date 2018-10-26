using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class HomelessStatus
    {
        public int HsId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Homelessness Status Option cannot be longer than 50 characters.")]
        [Column("HS_Options")]
        [Display(Name = "Homelessness Status Option")]
        public string HsOptions { get; set; }
    }
}
