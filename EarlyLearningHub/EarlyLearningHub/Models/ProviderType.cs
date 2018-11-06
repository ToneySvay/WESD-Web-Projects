using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class ProviderType
    {
        public ProviderType()
        {
            Provider = new HashSet<Provider>();
            ProviderLevel = new HashSet<ProviderLevel>();
        }

        public int PtId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Provider Type cannot be longer than 100 characters.")]
        [Column("PT_Name")]
        [Display(Name = "Provider Type")]
        public string PtName { get; set; }

        public ICollection<Provider> Provider { get; set; }
        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
