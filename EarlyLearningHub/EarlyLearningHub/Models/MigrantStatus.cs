using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class MigrantStatus
    {
        public int MsId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Migrant Status cannot be longer than 50 characters.")]
        [Column("MS_Options")]
        [Display(Name = "Migrant Options")]
        public string MsOptions { get; set; }
    }
}
