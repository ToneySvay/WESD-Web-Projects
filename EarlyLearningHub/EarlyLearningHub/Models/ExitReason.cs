using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class ExitReason
    {
        public ExitReason()
        {
            StudentLevel = new HashSet<StudentLevel>();
        }

        public int ErId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Exit Reason cannot be longer than 100 characters.")]
        [Column("ER_Type")]
        [Display(Name = "Exit Reason")]
        public string ErType { get; set; }

        public ICollection<StudentLevel> StudentLevel { get; set; }
    }
}
