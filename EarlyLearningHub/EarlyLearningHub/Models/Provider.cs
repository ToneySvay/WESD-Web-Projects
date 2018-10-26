using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class Provider
    {
        public int PrvdId { get; set; }
        public string PrvdName { get; set; }
        public int PrvdPtId { get; set; }

        public ProviderType PrvdPt { get; set; }
    }
}
