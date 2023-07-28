using System.Collections.Generic;

namespace GetBPR.Models
{
    internal struct Response
    {
        public Status Status { get; set; }
        public List<BPR> Data { get; set; }
    }
}
