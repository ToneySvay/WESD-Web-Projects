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
        }

        public int OptId { get; set; }

        [Required]
        [Display(Name = "Option Values")]
        public string OptValue { get; set; }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
