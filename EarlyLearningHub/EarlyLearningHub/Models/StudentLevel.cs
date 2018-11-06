using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class StudentLevel
    {
        public int SlId { get; set; }


        [Display(Name = "Provider Name ")]
        public int SlPrvdId { get; set; }

        [Display(Name = "Legal Last Name")]
        public string SlLegalFirstName { get; set; }

        [Display(Name = "Legal First Name")]
        public string SlLegalLastName { get; set; }

        [Display(Name = "Legal Middle Name")]
        public string SlLegalMiddleName { get; set; }

        [Display(Name = "Generation Code")]
        public string SlGenerationCode { get; set; }

        [Display(Name = "Other Name Type")]
        public int SlOntId { get; set; }

        [Display(Name = "Other Last Name")]
        public string SlOtherLastName { get; set; }

        [Display(Name = "Other First Name")]
        public string SlOtherFirstName { get; set; }

        [Display(Name = "Other Middle Name")]
        public string SlOtherMiddleName { get; set; }

        [Display(Name = "SSID# (if applicable) ")]
        public string SlSsid { get; set; }

        [Display(Name = "Birthdate (MM/DD/YYYY)")]
        public DateTime SlBirthdate { get; set; }

        [Display(Name = "Gender ")]
        public int SlGeId { get; set; }

        [Display(Name = "Address ")]
        public string SlAddress { get; set; }

        [Display(Name = "City ")]
        public string SlCity { get; set; }

        [Display(Name = "State ")]
        public int SlStId { get; set; }

        [Display(Name = "Postal Code")]
        public string SlPostalCode { get; set; }

        [Display(Name = "County")]
        public int SlCoId { get; set; }

        [Display(Name = "Email ")]
        public string SlEmail { get; set; }

        [Display(Name = "Phone Number ")]
        public string SlPhoneNumber { get; set; }

        [Display(Name = "Race/Ethnicity #1")]
        public int SlReId { get; set; }

        [Display(Name = "First Language")]
        public int? SlFirstLanguageLangId { get; set; }

        [Display(Name = "Second Language")]
        public int? SlSecondLanguageLangId { get; set; }

        [Display(Name = "Third Language")]
        public int? SlThirdLanguageLangId { get; set; }

        [Display(Name = "FPL %")]
        public int SlIncId { get; set; }

        [Display(Name = "In Foster Care")]
        public int SlFosterCareOptId { get; set; }

        [Display(Name = "Supplemental Nutrition Assistance Program (SNAP)")]
        public int SlSnapOptId { get; set; }

        [Display(Name = "Women, Infants, and Children (WIC)")]
        public int SlWicOptId { get; set; }

        [Display(Name = "Temporary Assistance for NeedyFamilies (TANF)")]
        public int SlTanfOptId { get; set; }

        [Display(Name = "Free or Reduced Lunch Program")]
        public int SlFreeReducedLunchProgramOptId { get; set; }

        [Display(Name = "Supplemental Security Income (SSI)")]
        public int SlSsiOptId { get; set; }

        [Display(Name = "Homelessness Status")]
        public int SlHomelessStatusOptId { get; set; }

        [Display(Name = "Migrant Status")]
        public int SlMigrantStatusOptId { get; set; }

        [Display(Name = "IFSP yes/no")]
        public int SlIfspOptId { get; set; }

        [Display(Name = "Required Specialized Services ")]
        public int? SlRequiredSpecializedServices { get; set; }

        [Display(Name = "Start Date ")]
        public DateTime? SlStartDate { get; set; }

        [Display(Name = "End Date ")]
        public DateTime? SlEndDate { get; set; }

        [Display(Name = "Reason for Exiting")]
        public int? SlErId { get; set; }

        [Display(Name = "Assigned Classrooom (Name)")]
        public string SlAssignedClassromName { get; set; }

        [Display(Name = "Average from Quarter 1")]
        public string SlAverageFromQ1 { get; set; }

        [Display(Name = "Average from Quarter 2")]
        public string SlAverageFromQ2 { get; set; }

        [Display(Name = "Average from Quarter 3")]
        public string SlAverageFromQ3 { get; set; }

        [Display(Name = "Average from Quarter 4")]
        public string SlAverageFromQ4 { get; set; }

        [Display(Name = "Receives Service")]
        public int? SlRecieveServicesOptId { get; set; }

        [Display(Name = "Child assessment Performed Date 1")]
        public DateTime? SlChildAssessmentPerformDate1 { get; set; }

        [Display(Name = "Child assessment Performed Date 2")]
        public DateTime? SlChildAssessmentPerformDate2 { get; set; }

        [Display(Name = "Child assessment Performed Date 3")]
        public DateTime? SlChildAssessmentPerformDate3 { get; set; }

        [Display(Name = "ASQ  Performed Date ")]
        public DateTime? SlAsqpeformedDate { get; set; }

        [Display(Name = "Parent Teacher Conference Date 1")]
        public DateTime? SlParentTeacherConferenceDate1 { get; set; }

        [Display(Name = "Parent Teacher Conference Date 2")]
        public DateTime? SlParentTeacherConferenceDate2 { get; set; }

        public County SlCo { get; set; }
        public ExitReason SlEr { get; set; }
        public Language SlFirstLanguageLang { get; set; }
        public Option SlFosterCareOpt { get; set; }
        public Option SlFreeReducedLunchProgramOpt { get; set; }
        public Option SlHomelessStatusOpt { get; set; }
        public Option SlIfspOpt { get; set; }
        public Income SlInc { get; set; }
        public Option SlMigrantStatusOpt { get; set; }
        public OtherNameType SlOnt { get; set; }
        public Provider SlPrvd { get; set; }
        public RaceEthnicity SlRe { get; set; }
        public Option SlRecieveServicesOpt { get; set; }
        public Language SlSecondLanguageLang { get; set; }
        public Option SlSnapOpt { get; set; }
        public Option SlSsiOpt { get; set; }
        public Option SlTanfOpt { get; set; }
        public Language SlThirdLanguageLang { get; set; }
        public Option SlWicOpt { get; set; }
    }
}
