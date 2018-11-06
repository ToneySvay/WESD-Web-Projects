using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class Option
    {
        public Option()
        {
            ProviderLevel = new HashSet<ProviderLevel>();
            StudentLevelSlFosterCareOpt = new HashSet<StudentLevel>();
            StudentLevelSlFreeReducedLunchProgramOpt = new HashSet<StudentLevel>();
            StudentLevelSlHomelessStatusOpt = new HashSet<StudentLevel>();
            StudentLevelSlIfspOpt = new HashSet<StudentLevel>();
            StudentLevelSlMigrantStatusOpt = new HashSet<StudentLevel>();
            StudentLevelSlRecieveServicesOpt = new HashSet<StudentLevel>();
            StudentLevelSlSnapOpt = new HashSet<StudentLevel>();
            StudentLevelSlSsiOpt = new HashSet<StudentLevel>();
            StudentLevelSlTanfOpt = new HashSet<StudentLevel>();
            StudentLevelSlWicOpt = new HashSet<StudentLevel>();
        }

        public int OptId { get; set; }

        [Required]
        [Display(Name = "Option Values")]
        public string OptValue { get; set; }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
        public ICollection<StudentLevel> StudentLevelSlFosterCareOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlFreeReducedLunchProgramOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlHomelessStatusOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlIfspOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlMigrantStatusOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlRecieveServicesOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlSnapOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlSsiOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlTanfOpt { get; set; }
        public ICollection<StudentLevel> StudentLevelSlWicOpt { get; set; }
    }
}
