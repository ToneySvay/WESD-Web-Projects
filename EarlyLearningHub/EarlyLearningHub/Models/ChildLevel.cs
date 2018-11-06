using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class ChildLevel
    {
        public int ClId { get; set; }
        public string ClLegalFirstName { get; set; }
        public string ClLegalLastName { get; set; }
        public string ClLegalMiddleName { get; set; }
        public string ClGenerationCode { get; set; }
        public int ClOntId { get; set; }
        public string ClOtherLastName { get; set; }
        public string ClOtherFirstName { get; set; }
        public string ClOtherMiddleName { get; set; }
        public string ClSsid { get; set; }
        public DateTime ClBirthdate { get; set; }
        public int ClGeId { get; set; }
        public string ClAddress { get; set; }
        public string ClCity { get; set; }
        public int ClStId { get; set; }
        public string ClPostalCode { get; set; }
        public int ClCoId { get; set; }
        public string ClEmail { get; set; }
        public string ClPhoneNumber { get; set; }
        public int ClReId { get; set; }
        public int ClFirstLanguageLangId { get; set; }
        public int ClSecondLanguageLangId { get; set; }
        public int ClThirdLanguageLangId { get; set; }
        public int ClIncId { get; set; }
        public int ClFosterCareOptId { get; set; }
        public int ClSnapOptId { get; set; }
        public int ClWicOptId { get; set; }
        public int ClTanfOptId { get; set; }
        public int ClFreeReducedLunchProgramOptId { get; set; }
        public int ClSsiOptId { get; set; }
        public int ClHomelessStatusOptId { get; set; }
        public int ClMigrantStatusOptId { get; set; }
        public int ClIfspOptId { get; set; }
        public int? ClRequiredSpecializedServices { get; set; }
        public DateTime? ClStartDate { get; set; }
        public DateTime? ClEndDate { get; set; }
        public int? ClErId { get; set; }
        public string ClAssignedClassromName { get; set; }
        public int? ClAtaId { get; set; }
        public int? ClRecieveServicesOptId { get; set; }
        public DateTime? ClChildAssessmentPerformDate1 { get; set; }
        public DateTime? ClChildAssessmentPerformDate2 { get; set; }
        public DateTime? ClChildAssessmentPerformDate3 { get; set; }
        public DateTime? ClAsqpeformedDate { get; set; }
        public DateTime? ClParentTeacherConferenceDate1 { get; set; }
        public DateTime? ClParentTeacherConferenceDate2 { get; set; }
    }
}
