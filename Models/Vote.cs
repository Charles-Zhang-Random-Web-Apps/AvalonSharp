using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvalonSharp.Models
{
    public class Vote
    {
        public Member Voter { get; set; }
        public bool InFavor { get; set; }

        public Vote(Member voter, bool inFavor)
        {
            Voter = voter;
            InFavor = inFavor;
        }
    }
}
