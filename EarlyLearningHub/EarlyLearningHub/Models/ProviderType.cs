using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class ProviderType
    {
        public ProviderType()
        {
            Provider = new HashSet<Provider>();
        }

        public int PtId { get; set; }
        public string PtName { get; set; }

        public ICollection<Provider> Provider { get; set; }
    }
}
