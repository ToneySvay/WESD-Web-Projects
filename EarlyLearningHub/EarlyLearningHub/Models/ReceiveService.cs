using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarlyLearningHub.Models
{
    public partial class ReceiveService
    {
        public int RsId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Receive Service cannot be longer than 50 characters.")]
        [Column("RS_Options")]
        [Display(Name = "Receive Service")]
        public string RsOptions { get; set; }
    }
}
