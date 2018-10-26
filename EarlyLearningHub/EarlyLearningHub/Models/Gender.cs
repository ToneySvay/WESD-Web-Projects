using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class Gender
    {
        public int GeId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Gender cannot be longer than 50 characters.")]
        [Column("GE_Name")]
        [Display(Name = "Gender")]
        public string GeName { get; set; }
        [Required]
        [StringLength(1, ErrorMessage = "Gender Abbreviation cannot be longer than 1 character.")]
        [Column("GE_Abbreviation")]
        [Display(Name = "Gender Code")]
        public string GeAbbreviation { get; set; }
    }
}
