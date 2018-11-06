using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class AttendanceAverage
    {
        public int AtaId { get; set; }
        public int AtaAttId { get; set; }
        public int ClId { get; set; }
        public string AtaAverage { get; set; }
    }
}
