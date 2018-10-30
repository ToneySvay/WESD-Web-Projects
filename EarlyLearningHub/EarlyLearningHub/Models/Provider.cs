using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class Provider
    {
        public Provider()
        {
            ProviderLevel = new HashSet<ProviderLevel>();
        }

        public int PrvdId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Provider cannot be longer than 100 characters.")]
        [Column("PRVD_Name")]
        [Display(Name = "Provider")]
        public string PrvdName { get; set; }
        [Required]
        [Display(Name = "Provider Type")]
        public int PrvdPtId { get; set; }
        [Display(Name = "Provider Type")]

        public ProviderType PrvdPt { get; set; }
        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
