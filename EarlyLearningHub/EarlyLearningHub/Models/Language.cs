using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class Language
    {
        public Language()
        {
            StudentLevelSlFirstLanguageLang = new HashSet<StudentLevel>();
            StudentLevelSlSecondLanguageLang = new HashSet<StudentLevel>();
            StudentLevelSlThirdLanguageLang = new HashSet<StudentLevel>();
        }

        public int LangId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Language cannot be longer than 100 characters.")]
        [Column("LANG_Name")]
        [Display(Name = "Language")]
        public string LangName { get; set; }

        public ICollection<StudentLevel> StudentLevelSlFirstLanguageLang { get; set; }
        public ICollection<StudentLevel> StudentLevelSlSecondLanguageLang { get; set; }
        public ICollection<StudentLevel> StudentLevelSlThirdLanguageLang { get; set; }
    }
}
