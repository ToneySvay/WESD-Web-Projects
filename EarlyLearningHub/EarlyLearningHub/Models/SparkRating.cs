using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class SparkRating
    {
        public int SrId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Migrant Status cannot be longer than 50 characters.")]
        [Column("SR_Name")]
        [Display(Name = "Spark Rating")]
        public string SrName { get; set; }
    }
}
