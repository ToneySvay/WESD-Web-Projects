using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class Attendance
    {
        public int AttId { get; set; }
        public string AttFromDateRange { get; set; }
        public DateTime? AttStartDate { get; set; }
        public DateTime? AttEndDate { get; set; }
        public string AttSchoolYear { get; set; }
    }
}
