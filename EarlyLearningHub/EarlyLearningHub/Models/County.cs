using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class County
    {
        public int CoId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "County name cannot be longer than 100 characters.")]
        [Column("CO_Name")]
        [Display(Name = "County")]
        public string CoName { get; set; }
    }
}
