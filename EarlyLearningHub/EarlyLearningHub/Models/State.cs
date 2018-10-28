using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class State
    {
        public int StId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "State cannot be longer than 100 characters.")]
        [Column("ST_Name")]
        [Display(Name = "State")]
        public string StName { get; set; }
        [Required]
        [StringLength(2, ErrorMessage = "State Abbreviation cannot be longer than 2 characters.")]
        [Column("ST_Abbreviation")]
        [Display(Name = "State Abbreviation")]
        public string StAbbreviation { get; set; }
    }
}
