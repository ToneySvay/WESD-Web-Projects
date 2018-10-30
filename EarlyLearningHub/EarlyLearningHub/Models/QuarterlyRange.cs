using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EarlyLearningHub.Models
{
    public partial class QuarterlyRange
    {
        public QuarterlyRange()
        {
            ProviderLevel = new HashSet<ProviderLevel>();
        }

        public int QrId { get; set; }
        [Required]
        [Display(Name = "Quarter")]
        public string QrName { get; set; }
        [Required]
        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        public DateTime? QrBeginDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? QrEndDate { get; set; }
        [Required]
        [Display(Name = "Is Active?")]
        public bool QrActive { get; set; }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
