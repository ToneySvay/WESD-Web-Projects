using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class ProviderLevel
    {
        public int PlId { get; set; }
        public int PlQrId { get; set; }
        public int PlElhId { get; set; }
        public int PlPrId { get; set; }
        public int PlPeId { get; set; }
        public int PlPtId { get; set; }
        public int PlLicencedOfficeChildCareOptId { get; set; }
        public int PlNumClassroomServingPpc { get; set; }
        public DateTime PlProgStartDate { get; set; }
        public DateTime PlProgEndDate { get; set; }
        public string PlDaysOfWeekPpsoccurs { get; set; }
        public TimeSpan PlDailyStartTime { get; set; }
        public TimeSpan PlDailyEndTime { get; set; }
        public int PlNumOfDaysInProgramYear { get; set; }
        public int PlPlannedServiceHours { get; set; }
        public int PlNumOfActualServiceHrsYtd { get; set; }
        public int PlNumChildrenOnWaitlist { get; set; }
        public string PlCurriculaUsedPpc { get; set; }
        public string PlChildLevelAssessmentTools { get; set; }
        public string PlChildLevelScreeningTools { get; set; }
        public int PlClassroomClassObservationCompleted { get; set; }
        public int PlSparkRatingBeginingOfYearSrId { get; set; }
        public int PlSparkRatingEndOfYearSrId { get; set; }

        public Hub PlElh { get; set; }
        public Option PlLicencedOfficeChildCareOpt { get; set; }
        public Person PlPe { get; set; }
        public Provider PlPt { get; set; }
        public ProviderType PlPtNavigation { get; set; }
        public QuarterlyRange PlQr { get; set; }
        public SparkRating PlSparkRatingBeginingOfYearSr { get; set; }
        public SparkRating PlSparkRatingEndOfYearSr { get; set; }
    }
}
