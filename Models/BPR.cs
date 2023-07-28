using System;

namespace GetBPR.Models
{
    public struct BPR
    {
        public DateTime ReadingDate { get; set; }
        public short SYS { get; set; }
        public short DIA { get; set; }
        public short Pulse { get; set; }

    }
}
