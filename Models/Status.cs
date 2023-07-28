using System.Collections.Generic;

namespace GetBPR.Models
{
    internal struct Status
    {
        public ushort StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<string> StatusErrors { get; set; }
    }
}
