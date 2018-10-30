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
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime QrBeginDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime QrEndDate { get; set; }

        [Required]
        [Display(Name = "Is Active?")]
        public bool QrActive { get; set; }


        [Display(Name = "Select the Quarter for this report")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string QuarterDate
        {
           
            get
            {
                return QrName + " (" + QrBeginDate.ToShortDateString() + "-" + QrEndDate.ToShortDateString() + ")";
            }
        }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
