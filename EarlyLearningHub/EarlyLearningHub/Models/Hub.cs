using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class Hub
    {
        public Hub()
        {
            ProviderLevel = new HashSet<ProviderLevel>();
        }


        public int ElhId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Early Learning Hub cannot be longer than 100 characters.")]
        [Column("ELH_Name")]
        [Display(Name = "Early Learning Hub")]
        public string ElhName { get; set; }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
