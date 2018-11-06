using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class FileUpload
    {
        public int FiId { get; set; }
        public string FiName { get; set; }
        public string FiContentType { get; set; }
        public byte[] FiData { get; set; }
    }
}
