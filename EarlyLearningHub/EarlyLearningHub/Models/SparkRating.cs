using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class SparkRating
    {
        public SparkRating()
        {
            ProviderLevelPlSparkRatingBeginingOfYearSr = new HashSet<ProviderLevel>();
            ProviderLevelPlSparkRatingEndOfYearSr = new HashSet<ProviderLevel>();
        }

        public int SrId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Migrant Status cannot be longer than 50 characters.")]
        [Column("SR_Name")]
        [Display(Name = "Spark Rating")]
        public string SrName { get; set; }

        public ICollection<ProviderLevel> ProviderLevelPlSparkRatingBeginingOfYearSr { get; set; }
        public ICollection<ProviderLevel> ProviderLevelPlSparkRatingEndOfYearSr { get; set; }
    }
}
