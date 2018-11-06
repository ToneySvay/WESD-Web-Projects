using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class RaceEthnicity
    {
        public RaceEthnicity()
        {
            StudentLevel = new HashSet<StudentLevel>();
        }

        public int ReId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Race/Ethnicity cannot be longer than 100 characters.")]
        [Column("RE_Name")]
        [Display(Name = "Race/Ethnicity")]
        public string ReName { get; set; }

        public ICollection<StudentLevel> StudentLevel { get; set; }
    }
}
