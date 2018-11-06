using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class OtherNameType
    {
        public OtherNameType()
        {
            StudentLevel = new HashSet<StudentLevel>();
        }

        public int OntId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Other Name Type cannot be longer than 50 characters.")]
        [Column("ONT_Name")]
        [Display(Name = "Other Name Type")]
        public string OntName { get; set; }

        public ICollection<StudentLevel> StudentLevel { get; set; }
    }
}
