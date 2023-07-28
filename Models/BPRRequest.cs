using System;

namespace GetBPR.Models
{
    internal struct BPRRequest
    {
        public short Age { get; set; }
        public short Qty { get; set; }
        public short Risk { get; set; }
    }
}
