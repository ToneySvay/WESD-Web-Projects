using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class StudentLevel
    {
        public int SlId { get; set; }
        public int SlPrvdId { get; set; }
        public string SlLegalFirstName { get; set; }
        public string SlLegalLastName { get; set; }
        public string SlLegalMiddleName { get; set; }
        public string SlGenerationCode { get; set; }
        public int SlOntId { get; set; }
        public string SlOtherLastName { get; set; }
        public string SlOtherFirstName { get; set; }
        public string SlOtherMiddleName { get; set; }
        public string SlSsid { get; set; }
        public DateTime SlBirthdate { get; set; }
        public int SlGeId { get; set; }
        public string SlAddress { get; set; }
        public string SlCity { get; set; }
        public int SlStId { get; set; }
        public string SlPostalCode { get; set; }
        public int SlCoId { get; set; }
        public string SlEmail { get; set; }
        public string SlPhoneNumber { get; set; }
        public int SlReId { get; set; }
        public int? SlFirstLanguageLangId { get; set; }
        public int? SlSecondLanguageLangId { get; set; }
        public int? SlThirdLanguageLangId { get; set; }
        public int SlIncId { get; set; }
        public int SlFosterCareOptId { get; set; }
        public int SlSnapOptId { get; set; }
        public int SlWicOptId { get; set; }
        public int SlTanfOptId { get; set; }
        public int SlFreeReducedLunchProgramOptId { get; set; }
        public int SlSsiOptId { get; set; }
        public int SlHomelessStatusOptId { get; set; }
        public int SlMigrantStatusOptId { get; set; }
        public int SlIfspOptId { get; set; }
        public int? SlRequiredSpecializedServices { get; set; }
        public DateTime? SlStartDate { get; set; }
        public DateTime? SlEndDate { get; set; }
        public int? SlErId { get; set; }
        public string SlAssignedClassromName { get; set; }
        public string SlAverageFromQ1 { get; set; }
        public string SlAverageFromQ2 { get; set; }
        public string SlAverageFromQ3 { get; set; }
        public string SlAverageFromQ4 { get; set; }
        public int? SlRecieveServicesOptId { get; set; }
        public DateTime? SlChildAssessmentPerformDate1 { get; set; }
        public DateTime? SlChildAssessmentPerformDate2 { get; set; }
        public DateTime? SlChildAssessmentPerformDate3 { get; set; }
        public DateTime? SlAsqpeformedDate { get; set; }
        public DateTime? SlParentTeacherConferenceDate1 { get; set; }
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
