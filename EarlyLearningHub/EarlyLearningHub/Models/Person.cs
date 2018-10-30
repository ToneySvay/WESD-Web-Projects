using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class Person
    {
        public Person()
        {
            ProviderLevel = new HashSet<ProviderLevel>();
        }

        public int PeId { get; set; }
        public string PeFirstName { get; set; }
        public string PeLastName { get; set; }
        public string PeEmail { get; set; }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
