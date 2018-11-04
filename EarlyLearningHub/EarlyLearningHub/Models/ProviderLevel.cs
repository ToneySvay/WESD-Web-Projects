using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EarlyLearningHub.Models
{
    public partial class ProviderLevel
    {
        public int PlId { get; set; }
        [Required]
        [Display(Name = "Select the quarter  for this report")]
        public int PlQrId { get; set; }
        [Required]
        [Display(Name = "Early Learning Hub")]
        public int PlElhId { get; set; }
        [Required]
        [Display(Name = "Provider Name")]
        public int PlPrvdId { get; set; }
        [Required]
        [Display(Name = "Email of the person filling out this form")]
        public int PlPeId { get; set; }
        [Required]
        [Display(Name = "Provider Type")]
        public int PlPtId { get; set; }
        [Required]
        [Display(Name = "Are you licensed by the Office of Child Care?")]
        public int PlLicencedOfficeChildCareOptId { get; set; }
        [Required]
        [Display(Name = "Total number of classrooms serving Preschool Promise children")]
        public int PlNumClassroomServingPpc { get; set; }

        //[RegularExpression(@"^((0|1)\d{1})/((0|1|2)\d{1})/((19|20)\d{2})",ErrorMessage = "Format must be in MM/DD/YYYY eg. 01/01/2018")]
        [Required]
        [Display(Name = "Program Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PlProgStartDate { get; set; }

        //[RegularExpression(@"^((0|1)\d{1})/((0|1|2)\d{1})/((19|20)\d{2})",ErrorMessage = "Format must be in MM / DD / YYYY eg. 01 / 01 / 2018")]
        [Required]
        [Display(Name = "Program End Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PlProgEndDate { get; set; }
        [Required]
        [Display(Name = "Which days of the week Preschool Promise services are occurring:")]
        public string PlDaysOfWeekPpsoccurs { get; set; }
        [Required]
        [Display(Name = "Daily Start Time")]
        public TimeSpan PlDailyStartTime { get; set; }
        [Required]
        [Display(Name = "Daily End Time")]
        public TimeSpan PlDailyEndTime { get; set; }
        [Required]
        [Display(Name = "Number of Days in Program Year ")]
        public int PlNumOfDaysInProgramYear { get; set; }
        [Required]
        [Display(Name = "Number of Planned Service Hours ")]
        public int PlPlannedServiceHours { get; set; }
        [Required]
        [Display(Name = "Number of Actual Service Hours provided YTD ")]
        public int PlNumOfActualServiceHrsYtd { get; set; }
        [Required]
        [Display(Name = "Number of children on waitlist/Interest List ")]
        public int PlNumChildrenOnWaitlist { get; set; }
        [Required]
        [Display(Name = "Curricula used for Preschool Promise children ")]
        public string PlCurriculaUsedPpc { get; set; }
        [Required]
        [Display(Name = "Child Level Assessment Tools ")]
        public string PlChildLevelAssessmentTools { get; set; }
        [Required]
        [Display(Name = "Child Level Screening Tools (includes hearing, dental, vision, ASQ and other)")]
        public string PlChildLevelScreeningTools { get; set; }
        [Required]
        [Display(Name = "How many of the classrooms have had CLASS Observation completed? ")]
        public int PlClassroomClassObservationCompleted { get; set; }
        [Required]
        [Display(Name = "Spark rating at the beginning of program year")]
        public int PlSparkRatingBeginingOfYearSrId { get; set; }
        [Required]
        [Display(Name = "Spark rating at the end of program year ")]
        public int PlSparkRatingEndOfYearSrId { get; set; }

        public Hub PlElh { get; set; }
        public Option PlLicencedOfficeChildCareOpt { get; set; }
        public Person PlPe { get; set; }
        public Provider PlPrvd { get; set; }
        public ProviderType PlPt { get; set; }
        public QuarterlyRange PlQr { get; set; }
        public SparkRating PlSparkRatingBeginingOfYearSr { get; set; }
        public SparkRating PlSparkRatingEndOfYearSr { get; set; }
    }
}
